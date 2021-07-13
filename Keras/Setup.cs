using System;
using System.Diagnostics;
using Python.Runtime;

namespace Keras
{
    public class Setup
    {
        private static readonly string[] modules = {"keras", "numpy"};

        private static readonly string[] backendmodules =
            {"tensorflow", "tensorflow-gpu", "cntk", "cntk-gpu", "plaidml-keras"};

        private static string pythonCommand = "python";
        private static string pipCommand = "pip";

        public static string KerasModule { get; set; } = "tensorflow.keras";

        public static void UseTfKeras()
        {
            KerasModule = "tensorflow.keras";
        }

        public static void UseOldKeras()
        {
            KerasModule = "keras";
        }

        public static void Run(SetupBackend backend = SetupBackend.TensorflowCPU)
        {
            var pyversion = CheckPythonVer();
            if (pyversion == 0)
                throw new Exception(
                    "Python 3.6 not found! Please download and install from https://www.python.org/downloads/release/python-368/");

            if (pyversion == 36)
            {
                foreach (var item in modules) InstallModule(item);

                InstallModule(backendmodules[(int) backend]);
            }
            else
            {
                throw new Exception("Version not supported: " + pyversion);
            }
        }

        public static void InstallModule(string name)
        {
            if (CheckModule(name) == null)
            {
                Console.WriteLine("Installing {0}.....", name);
                var result = RunCommand(pipCommand, string.Format("install {0}", name));
                Console.Write("Done!");
            }
            else
            {
                Console.WriteLine("{0} already installed!", name);
            }
        }

        public static PyModuleInfo CheckModule(string name)
        {
            var pyversion = CheckPythonVer();
            if (pyversion == 0)
                throw new Exception("Python 3.6 not found");
            PyModuleInfo result = null;
            if (pyversion == 36)
            {
                var info = RunCommand(pipCommand, string.Format("show {0}", name));
                if (!string.IsNullOrWhiteSpace(info))
                {
                    var lines = info.Split('\n');
                    result = new PyModuleInfo();
                    foreach (var item in lines)
                    {
                        if (item.Contains("Name: ")) result.Name = item.Replace("Name: ", "").Trim();

                        if (item.Contains("Version: ")) result.Version = item.Replace("Version: ", "").Trim();

                        if (item.Contains("Summary: ")) result.Summary = item.Replace("Summary: ", "").Trim();

                        if (item.Contains("Author: ")) result.Author = item.Replace("Author: ", "").Trim();

                        if (item.Contains("Author-email: "))
                            result.AuthorEmail = item.Replace("Author-email: ", "").Trim();

                        if (item.Contains("License: ")) result.License = item.Replace("License: ", "").Trim();

                        if (item.Contains("Location: ")) result.Location = item.Replace("Location: ", "").Trim();

                        if (item.Contains("Requires: ")) result.Requires = item.Replace("Requires: ", "").Trim();

                        if (item.Contains("Required-by: "))
                            result.RequiredBy = item.Replace("Required-by: ", "").Trim();

                        if (item.Contains("Home-page: ")) result.HomePage = item.Replace("Home-page: ", "").Trim();
                    }
                }
            }
            else
            {
                throw new Exception("Version not supported: " + pyversion);
            }

            return result;
        }

        private static int CheckPythonVer()
        {
            try
            {
                var result = RunCommand("python", "--version");
                var versionSplit = result.Replace("Python", "").Trim().Split('.');

                return Convert.ToInt32(versionSplit[0] + versionSplit[1]);
            }
            catch
            {
                try
                {
                    var result = RunCommand("python3", "--version");
                    var versionSplit = result.Replace("Python", "").Trim().Split('.');

                    pythonCommand = "python3";
                    pipCommand = "pip3";
                    return Convert.ToInt32(versionSplit[0] + versionSplit[1]);
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }

        private static string RunCommand(string exec, string arguments)
        {
            var process = new Process();
            var startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.FileName = exec;
            startInfo.Arguments = arguments;
            process.StartInfo = startInfo;
            process.Start();
            var error = process.StandardError.ReadToEnd();
            if (!string.IsNullOrWhiteSpace(error))
                throw new Exception(error);

            return process.StandardOutput.ReadToEnd();
        }

        public static void SetPythonPath(string path)
        {
            Environment.SetEnvironmentVariable("PYTHON_PATH", path);
            Environment.SetEnvironmentVariable("PYTHON_HOME", path);

            PythonEngine.PythonHome = path;
            PythonEngine.Initialize();
        }
    }
}