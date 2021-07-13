using System;

namespace Keras.Layers
{
    /// <summary>
    ///     Depthwise separable 2D convolution.
    ///     Depthwise Separable convolutions consists in performing just the first step in a depthwise spatial
    ///     convolution(which acts on each input channel separately). The depth_multiplier argument controls how many output
    ///     channels are generated per input channel in the depthwise step.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class DepthwiseConv2D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="DepthwiseConv2D" /> class.
        /// </summary>
        /// <param name="kernel_size">
        ///     An integer or tuple/list of 2 integers, specifying the height and width of the 2D
        ///     convolution window. Can be a single integer to specify the same value for all spatial dimensions.
        /// </param>
        /// <param name="strides">
        ///     An integer or tuple/list of 2 integers, specifying the strides of the convolution along the
        ///     height and width. Can be a single integer to specify the same value for all spatial dimensions. Specifying any
        ///     stride value != 1 is incompatible with specifying any dilation_rate value != 1.
        /// </param>
        /// <param name="padding"> one of "valid" or "same" (case-insensitive).</param>
        /// <param name="depth_multiplier">
        ///     The number of depthwise convolution output channels for each input channel. The total
        ///     number of depthwise convolution output channels will be equal to filters_in * depth_multiplier.
        /// </param>
        /// <param name="data_format">
        ///     A string, one of "channels_last" or "channels_first". The ordering of the dimensions in the
        ///     inputs. "channels_last" corresponds to inputs with shape (batch, height, width, channels) while "channels_first"
        ///     corresponds to inputs with shape (batch, channels, height, width). It defaults to the image_data_format value found
        ///     in your Keras config file at ~/.keras/keras.json. If you never set it, then it will be 'channels_last'.
        /// </param>
        /// <param name="activation">
        ///     Activation function to use (see activations). If you don't specify anything, no activation is
        ///     applied (ie. 'linear' activation: a(x) = x).
        /// </param>
        /// <param name="use_bias"> Boolean, whether the layer uses a bias vector.</param>
        /// <param name="depthwise_initializer"> Initializer for the depthwise kernel matrix (see initializers).</param>
        /// <param name="bias_initializer"> Initializer for the bias vector (see initializers).</param>
        /// <param name="depthwise_regularizer"> Regularizer function applied to the depthwise kernel matrix (see regularizer).</param>
        /// <param name="bias_regularizer"> Regularizer function applied to the bias vector (see regularizer).</param>
        /// <param name="activity_regularizer">
        ///     Regularizer function applied to the output of the layer (its 'activation'). (see
        ///     regularizer).
        /// </param>
        /// <param name="depthwise_constraint"> Constraint function applied to the depthwise kernel matrix (see constraints).</param>
        /// <param name="bias_constraint"> Constraint function applied to the bias vector (see constraints).</param>
        /// <param name="bias_regularizer"> Regularizer function applied to the bias vector (see regularizer).</param>
        /// <param name="activity_regularizer">
        ///     Regularizer function applied to the output of the layer (its "activation"). (see
        ///     regularizer).
        /// </param>
        /// <param name="depthwise_constraint"> Constraint function applied to the depthwise kernel matrix (see constraints).</param>
        /// <param name="pointwise_constraint"> Constraint function applied to the pointwise kernel matrix (see constraints).</param>
        /// <param name="bias_constraint"> Constraint function applied to the bias vector (see constraints).</param>
        /// <param name="input_shape">
        ///     4D tensor with shape: (batch, channels, rows, cols) if data_format is "channels_first" or 4D
        ///     tensor with shape: (batch, rows, cols, channels) if data_format is "channels_last".
        /// </param>
        public DepthwiseConv2D(Tuple<int, int> kernel_size, Tuple<int, int> strides = null, string padding = "valid",
            int depth_multiplier = 1, string data_format = "", string activation = "", bool use_bias = true,
            string depthwise_initializer = "glorot_uniform",
            string bias_initializer = "zeros", string depthwise_regularizer = "", string bias_regularizer = "",
            string activity_regularizer = "",
            string depthwise_constraint = "", string bias_constraint = "", Shape input_shape = null)
        {
            Parameters["kernel_size"] = new Shape(kernel_size.Item1, kernel_size.Item2);
            Parameters["strides"] = strides == null ? new Shape(1, 1) : new Shape(strides.Item1, strides.Item2);
            Parameters["padding"] = padding;
            Parameters["depth_multiplier"] = depth_multiplier;
            Parameters["data_format"] = data_format;
            Parameters["activation"] = activation;
            Parameters["use_bias"] = use_bias;
            Parameters["depthwise_initializer"] = depthwise_initializer;
            Parameters["bias_initializer"] = bias_initializer;
            Parameters["depthwise_regularizer"] = depthwise_regularizer;
            Parameters["bias_initializer"] = bias_initializer;
            Parameters["bias_regularizer"] = bias_regularizer;
            Parameters["activity_regularizer"] = activity_regularizer;
            Parameters["depthwise_constraint"] = depthwise_constraint;
            Parameters["bias_constraint"] = bias_constraint;
            Parameters["input_shape"] = input_shape;

            PyInstance = Instance.keras.layers.DepthwiseConv2D;
            Init();
        }
    }
}