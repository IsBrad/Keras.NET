namespace Keras.Layers
{
    /// <summary>
    ///     Upsampling layer for 1D inputs.    Repeats each temporal step size times along the time axis.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class UpSampling1D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UpSampling1D" /> class.
        /// </summary>
        /// <param name="size">integer. Upsampling factor.</param>
        /// <param name="input_shape">3D tensor with shape: (batch, steps, features).</param>
        public UpSampling1D(int size = 2, Shape input_shape = null)
        {
            Parameters["size"] = size;
            Parameters["input_shape"] = input_shape;
            PyInstance = Instance.keras.layers.UpSampling1D;
            Init();
        }
    }
}