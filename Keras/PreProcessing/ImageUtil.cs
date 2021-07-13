using System.Collections.Generic;
using Keras.Applications;
using Keras.Helper;
using Numpy;
using Python.Runtime;

namespace Keras.PreProcessing
{
    public class ImageUtil : Base
    {
        private static readonly dynamic caller = Instance.keras.preprocessing.image;

        /// <summary>
        ///     Array to img.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="data_format">The data format.</param>
        /// <param name="scale">if set to <c>true</c> [scale].</param>
        /// <param name="dtype">The dtype.</param>
        /// <returns></returns>
        public static dynamic ArrayToImg(NDarray x, string data_format = "", bool scale = true, string dtype = "")
        {
            var parameters = new Dictionary<string, object>();
            parameters["x"] = x;
            parameters["data_format"] = data_format;
            parameters["scale"] = scale;
            parameters["dtype"] = dtype;

            return InvokeStaticMethod(caller, "array_to_img", parameters);
        }

        /// <summary>
        ///     Images to array.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="data_format">The data format.</param>
        /// <param name="dtype">The dtype.</param>
        /// <returns></returns>
        public static NDarray ImageToArray(dynamic image, string data_format = "", string dtype = "")
        {
            var parameters = new Dictionary<string, object>();
            parameters["image"] = image;
            parameters["data_format"] = data_format;
            parameters["dtype"] = dtype;

            return new NDarray((PyObject) InvokeStaticMethod(caller, "img_to_array", parameters));
        }

        /// <summary>
        ///     Loads the img.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="color_mode">The color mode.</param>
        /// <param name="target_size">Size of the target.</param>
        /// <param name="interpolation">The interpolation.</param>
        /// <returns></returns>
        public static dynamic LoadImg(string path, string color_mode = "rgb", Shape target_size = null,
            string interpolation = "nearest")
        {
            var parameters = new Dictionary<string, object>();
            parameters["path"] = path;
            parameters["color_mode"] = color_mode;
            parameters["target_size"] = target_size;
            parameters["interpolation"] = interpolation;

            return InvokeStaticMethod(caller, "load_img", parameters);
        }

        /// <summary>
        ///     Decodes the predictions.
        /// </summary>
        /// <param name="preds">The preds.</param>
        /// <param name="top">The top.</param>
        /// <returns></returns>
        public static ImageNetPrediction[] DecodePredictions(NDarray preds, int top = 3)
        {
            var parameters = new Dictionary<string, object>();
            parameters["preds"] = preds;
            parameters["top"] = top;
            var predobj = (PyObject) InvokeStaticMethod(Instance.keras.applications.resnet50, "decode_predictions",
                parameters);
            var d = predobj.ToString();
            var list = TupleSolver.TupleToList<object>(predobj);
            return null;
        }

        /// <summary>
        ///     Preprocesses the input.
        /// </summary>
        /// <param name="x">The input tensor.</param>
        /// <returns></returns>
        public static NDarray PreprocessInput(NDarray x, string data_format = "channels_last", string mode = "caffe")
        {
            var parameters = new Dictionary<string, object>();
            parameters["x"] = x;
            parameters["data_format"] = data_format;
            parameters["mode"] = mode;
            return new NDarray((PyObject) InvokeStaticMethod(Instance.keras.applications.resnet50, "preprocess_input",
                parameters));
        }
    }
}