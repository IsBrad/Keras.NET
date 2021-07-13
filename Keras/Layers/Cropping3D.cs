using System;

namespace Keras.Layers
{
    /// <summary>
    ///     Cropping layer for 3D data (e.g. spatial or spatio-temporal).
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class Cropping3D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Cropping3D" /> class.
        /// </summary>
        /// <param name="cropping">int, or tuple of 3 ints, or tuple of 3 tuples of 2 ints.</param>
        /// <param name="data_format">
        ///     A string, one of "channels_last" or "channels_first". The ordering of the dimensions in the
        ///     inputs.  "channels_last" corresponds to inputs with shape  (batch, spatial_dim1, spatial_dim2, spatial_dim3,
        ///     channels) while "channels_first" corresponds to inputs with shape  (batch, channels, spatial_dim1, spatial_dim2,
        ///     spatial_dim3). It defaults to the image_data_format value found in your Keras config file at ~/.keras/keras.json.
        ///     If you never set it, then it will be "channels_last".
        /// </param>
        /// <param name="input_shape">
        ///     5D tensor with shape: - If data_format is "channels_last":  (batch, first_axis_to_crop,
        ///     second_axis_to_crop, third_axis_to_crop,        depth) - If data_format is "channels_first":  (batch, depth,
        ///     first_axis_to_crop, second_axis_to_crop, third_axis_to_crop)
        /// </param>
        public Cropping3D(Tuple<Tuple<int, int>, Tuple<int, int>, Tuple<int, int>> cropping, string data_format = "",
            Shape input_shape = null)
        {
            Parameters["cropping"] = cropping == null
                ? new[] {new Shape(1, 1), new Shape(1, 1), new Shape(1, 1)}
                : new[]
                {
                    new Shape(cropping.Item1.Item1, cropping.Item1.Item2),
                    new Shape(cropping.Item2.Item1, cropping.Item2.Item2),
                    new Shape(cropping.Item3.Item1, cropping.Item3.Item2)
                };
            Parameters["data_format"] = data_format;
            Parameters["input_shape"] = input_shape;
            PyInstance = Instance.keras.layers.Cropping3D;
            Init();
        }
    }
}