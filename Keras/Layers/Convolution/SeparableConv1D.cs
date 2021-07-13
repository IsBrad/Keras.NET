namespace Keras.Layers
{
    /// <summary>
    ///     Depthwise separable 1D convolution.
    ///     Separable convolutions consist in first performing a depthwise spatial convolution(which acts on each input channel
    ///     separately) followed by a pointwise convolution which mixes together the resulting output channels.The
    ///     depth_multiplier argument controls how many output channels are generated per input channel in the depthwise step.
    ///     Intuitively, separable convolutions can be understood as a way to factorize a convolution kernel into two smaller
    ///     kernels, or as an extreme version of an Inception block.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class SeparableConv1D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SeparableConv1D" /> class.
        /// </summary>
        /// <param name="filters">
        ///     Integer, the dimensionality of the output space (i.e. the number of output filters in the
        ///     convolution).
        /// </param>
        /// <param name="kernel_size">
        ///     An integer or tuple/list of single integer, specifying the length of the 1D convolution
        ///     window.
        /// </param>
        /// <param name="strides">
        ///     An integer or tuple/list of single integer, specifying the stride length of the convolution.
        ///     Specifying any stride value != 1 is incompatible with specifying any dilation_rate value != 1.
        /// </param>
        /// <param name="padding"> one of "valid" or "same" (case-insensitive).</param>
        /// <param name="data_format">
        ///     A string, one of "channels_last" or "channels_first". The ordering of the dimensions in the
        ///     inputs. "channels_last" corresponds to inputs with shape (batch, steps, channels) while "channels_first"
        ///     corresponds to inputs with shape (batch, channels, steps).
        /// </param>
        /// <param name="dilation_rate">
        ///     An integer or tuple/list of a single integer, specifying the dilation rate to use for
        ///     dilated convolution. Currently, specifying any dilation_rate value != 1 is incompatible with specifying any strides
        ///     value != 1.
        /// </param>
        /// <param name="depth_multiplier">
        ///     The number of depthwise convolution output channels for each input channel. The total
        ///     number of depthwise convolution output channels will be equal to filters_in * depth_multiplier.
        /// </param>
        /// <param name="activation">
        ///     Activation function to use (see activations). If you don't specify anything, no activation is
        ///     applied (ie. "linear" activation: a(x) = x).
        /// </param>
        /// <param name="use_bias"> Boolean, whether the layer uses a bias vector.</param>
        /// <param name="depthwise_initializer"> Initializer for the depthwise kernel matrix (see initializers).</param>
        /// <param name="pointwise_initializer"> Initializer for the pointwise kernel matrix (see initializers).</param>
        /// <param name="bias_initializer"> Initializer for the bias vector (see initializers).</param>
        /// <param name="depthwise_regularizer"> Regularizer function applied to the depthwise kernel matrix (see regularizer).</param>
        /// <param name="pointwise_regularizer"> Regularizer function applied to the pointwise kernel matrix (see regularizer).</param>
        /// <param name="bias_regularizer"> Regularizer function applied to the bias vector (see regularizer).</param>
        /// <param name="activity_regularizer">
        ///     Regularizer function applied to the output of the layer (its "activation"). (see
        ///     regularizer).
        /// </param>
        /// <param name="depthwise_constraint"> Constraint function applied to the depthwise kernel matrix (see constraints).</param>
        /// <param name="pointwise_constraint"> Constraint function applied to the pointwise kernel matrix (see constraints).</param>
        /// <param name="bias_constraint"> Constraint function applied to the bias vector (see constraints).</param>
        /// <param name="input_shape">
        ///     3D tensor with shape: (batch, channels, steps) if data_format is "channels_first" or 3D
        ///     tensor with shape: (batch, steps, channels) if data_format is "channels_last".
        /// </param>
        public SeparableConv1D(int filters, int kernel_size, int strides = 1, string padding = "valid",
            string data_format = "channels_last",
            int dilation_rate = 1, int depth_multiplier = 1, string activation = "", bool use_bias = true,
            string depthwise_initializer = "glorot_uniform",
            string pointwise_initializer = "glorot_uniform", string bias_initializer = "zeros",
            string depthwise_regularizer = "",
            string pointwise_regularizer = "", string bias_regularizer = "", string activity_regularizer = "",
            string depthwise_constraint = "",
            string pointwise_constraint = "", string bias_constraint = "", Shape input_shape = null)
        {
            Parameters["filters"] = filters;
            Parameters["kernel_size"] = kernel_size;
            Parameters["strides"] = strides;
            Parameters["padding"] = padding;
            Parameters["data_format"] = data_format;
            Parameters["dilation_rate"] = dilation_rate;
            Parameters["depth_multiplier"] = depth_multiplier;
            Parameters["activation"] = activation;
            Parameters["use_bias"] = use_bias;
            Parameters["depthwise_initializer"] = depthwise_initializer;
            Parameters["pointwise_initializer"] = pointwise_initializer;
            Parameters["bias_initializer"] = bias_initializer;
            Parameters["depthwise_regularizer"] = depthwise_regularizer;
            Parameters["bias_initializer"] = bias_initializer;
            Parameters["pointwise_regularizer"] = pointwise_regularizer;
            Parameters["bias_regularizer"] = bias_regularizer;
            Parameters["activity_regularizer"] = activity_regularizer;
            Parameters["depthwise_constraint"] = depthwise_constraint;
            Parameters["pointwise_constraint"] = pointwise_constraint;
            Parameters["bias_constraint"] = bias_constraint;
            Parameters["input_shape"] = input_shape;

            PyInstance = Instance.keras.layers.SeparableConv1D;
            Init();
        }
    }
}