namespace Keras.Layers
{
    /// <summary>
    ///     Zero-padding layer for 1D input (e.g. temporal sequence).
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class ZeroPadding1D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ZeroPadding1D" /> class.
        /// </summary>
        /// <param name="padding"> int, or tuple of int (length 2), or dictionary.</param>
        /// <param name="input_shape">3D tensor with shape (batch, axis_to_pad, features)</param>
        public ZeroPadding1D(int padding = 1, Shape input_shape = null)
        {
            Parameters["padding"] = padding;
            Parameters["input_shape"] = input_shape;
            PyInstance = Instance.keras.layers.ZeroPadding1D;
            Init();
        }
    }
}