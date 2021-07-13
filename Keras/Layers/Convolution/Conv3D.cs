using System;

namespace Keras.Layers
{
    /// <summary>
    ///     3D convolution layer (e.g. spatial convolution over volumes).
    ///     This layer creates a convolution kernel that is convolved with the layer input to produce a tensor of outputs.If
    ///     use_bias is True, a bias vector is created and added to the outputs.Finally, if activation is not None, it is
    ///     applied to the outputs as well.
    ///     When using this layer as the first layer in a model, provide the keyword argument input_shape (tuple of integers,
    ///     does not include the batch axis), e.g. input_shape=(128, 128, 128, 1) for 128x128x128 volumes with a single
    ///     channel, in data_format="channels_last".
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class Conv3D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Conv3D" /> class.
        /// </summary>
        /// <param name="filters">
        ///     Integer, the dimensionality of the output space (i.e. the number of output filters in the
        ///     convolution).
        /// </param>
        /// <param name="kernel_size">
        ///     An integer or tuple/list of 3 integers, specifying the depth, height and width of the 3D
        ///     convolution window. Can be a single integer to specify the same value for all spatial dimensions.
        /// </param>
        /// <param name="strides">
        ///     An integer or tuple/list of 3 integers, specifying the strides of the convolution along each
        ///     spatial dimension. Can be a single integer to specify the same value for all spatial dimensions. Specifying any
        ///     stride value != 1 is incompatible with specifying any dilation_ratevalue != 1.
        /// </param>
        /// <param name="padding"> one of "valid" or "same" (case-insensitive).</param>
        /// <param name="data_format">
        ///     A string, one of "channels_last" or "channels_first". The ordering of the dimensions in the
        ///     inputs. "channels_last" corresponds to inputs with shape (batch, spatial_dim1, spatial_dim2, spatial_dim3,
        ///     channels) while "channels_first" corresponds to inputs with shape (batch, channels, spatial_dim1, spatial_dim2,
        ///     spatial_dim3). It defaults to the image_data_format value found in your Keras config file at ~/.keras/keras.json.
        ///     If you never set it, then it will be "channels_last".
        /// </param>
        /// <param name="dilation_rate">
        ///     an integer or tuple/list of 3 integers, specifying the dilation rate to use for dilated
        ///     convolution. Can be a single integer to specify the same value for all spatial dimensions. Currently, specifying
        ///     any dilation_rate value != 1 is incompatible with specifying any stride value != 1.
        /// </param>
        /// <param name="activation">
        ///     Activation function to use (see activations). If you don't specify anything, no activation is
        ///     applied (ie. "linear" activation: a(x) = x).
        /// </param>
        /// <param name="use_bias"> Boolean, whether the layer uses a bias vector.</param>
        /// <param name="kernel_initializer"> Initializer for the kernel weights matrix (see initializers).</param>
        /// <param name="bias_initializer"> Initializer for the bias vector (see initializers).</param>
        /// <param name="kernel_regularizer"> Regularizer function applied to the kernel weights matrix (see regularizer).</param>
        /// <param name="bias_regularizer"> Regularizer function applied to the bias vector (see regularizer).</param>
        /// <param name="activity_regularizer">
        ///     Regularizer function applied to the output of the layer (its "activation"). (see
        ///     regularizer).
        /// </param>
        /// <param name="kernel_constraint"> Constraint function applied to the kernel matrix (see constraints).</param>
        /// <param name="bias_constraint"> Constraint function applied to the bias vector (see constraints).</param>
        /// <param name="bias_constraint"> Constraint function applied to the bias vector (see constraints).</param>
        /// <param name="depthwise_constraint"> Constraint function applied to the depthwise kernel matrix (see constraints).</param>
        /// <param name="pointwise_constraint"> Constraint function applied to the pointwise kernel matrix (see constraints).</param>
        /// <param name="bias_constraint"> Constraint function applied to the bias vector (see constraints).</param>
        /// <param name="input_shape">
        ///     5D tensor with shape: (batch, channels, conv_dim1, conv_dim2, conv_dim3) if data_format is
        ///     "channels_first" or 5D tensor with shape: (batch, conv_dim1, conv_dim2, conv_dim3, channels) if data_format is
        ///     "channels_last".
        /// </param>
        public Conv3D(int filters, (int, int, int) kernel_size, (int, int, int)? strides = null,
            string padding = "valid", string data_format = "channels_last",
            (int, int, int)? dilation_rate = null, string activation = "", bool use_bias = true,
            string kernel_initializer = "glorot_uniform",
            string bias_initializer = "zeros", string kernel_regularizer = "", string bias_regularizer = "",
            string activity_regularizer = "", string kernel_constraint = "", string bias_constraint = "",
            Shape input_shape = null)
        {
            Parameters["filters"] = filters;
            Parameters["kernel_size"] = new Shape(kernel_size.Item1, kernel_size.Item2, kernel_size.Item3);
            Parameters["strides"] = strides.HasValue
                ? new Shape(strides.Value.Item1, strides.Value.Item2, strides.Value.Item3)
                : new Shape(1, 1, 1);
            Parameters["padding"] = padding;
            Parameters["data_format"] = data_format;
            Parameters["dilation_rate"] = dilation_rate.HasValue
                    ? new Shape(dilation_rate.Value.Item1, dilation_rate.Value.Item2, dilation_rate.Value.Item3)
                    : new Shape(1, 1, 1)
                ;
            Parameters["activation"] = activation;
            Parameters["use_bias"] = use_bias;
            Parameters["kernel_initializer"] = kernel_initializer;
            Parameters["bias_initializer"] = bias_initializer;
            Parameters["kernel_regularizer"] = kernel_regularizer;
            Parameters["bias_regularizer"] = bias_regularizer;
            Parameters["activity_regularizer"] = activity_regularizer;
            Parameters["kernel_constraint"] = kernel_constraint;
            Parameters["bias_constraint"] = bias_constraint;
            Parameters["input_shape"] = input_shape;

            PyInstance = Instance.keras.layers.Conv3D;
            Init();
        }
    }
}