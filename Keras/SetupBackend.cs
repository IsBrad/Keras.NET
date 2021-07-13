namespace Keras
{
    public enum SetupBackend
    {
        TensorflowCPU = 0,
        TensorflowGPU,
        CNTKCPU,
        CNTKGPU,
        PlaidML
    }
}