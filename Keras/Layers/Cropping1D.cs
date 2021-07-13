using System;

namespace Keras.Layers
{
    /// <summary>
    ///     Cropping layer for 1D input (e.g. temporal sequence).    It crops along the time dimension(axis 1).
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class Cropping1D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Cropping1D" /> class.
        /// </summary>
        /// <param name="cropping">
        ///     int or tuple of int (length 2) How many units should be trimmed off at the beginning and end of
        ///     the cropping dimension (axis 1). If a single int is provided, the same value will be used for both.
        /// </param>
        /// <param name="input_shape">3D tensor with shape (batch, axis_to_crop, features)</param>
        public Cropping1D(Tuple<int, int> cropping, Shape input_shape = null)
        {
            Parameters["cropping"] = cropping == null ? new Shape(1, 1) : new Shape(cropping.Item1, cropping.Item2);
            Parameters["input_shape"] = input_shape;
            PyInstance = Instance.keras.layers.Cropping1D;
            Init();
        }
    }
}