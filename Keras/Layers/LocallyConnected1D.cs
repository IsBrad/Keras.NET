namespace Keras.Layers
{
    /// <summary>
    ///     Locally-connected layer for 1D inputs.
    ///     The LocallyConnected1D layer works similarly to the Conv1D layer, except that weights are unshared, that is, a
    ///     different set of filters is applied at each different patch of the input.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class LocallyConnected1D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LocallyConnected1D" /> class.
        /// </summary>
        /// <param name="filters">
        ///     Integer, the dimensionality of the output space (i.e. the number of output filters in the
        ///     convolution).
        /// </param>
        /// <param name="kernel_size">
        ///     An integer or tuple/list of a single integer, specifying the length of the 1D convolution
        ///     window.
        /// </param>
        /// <param name="strides">
        ///     An integer or tuple/list of a single integer, specifying the stride length of the convolution.
        ///     Specifying any stride value != 1 is incompatible with specifying any dilation_ratevalue != 1.
        /// </param>
        /// <param name="padding"> Currently only supports "valid" (case-insensitive). "same" may be supported in the future.</param>
        /// <param name="data_format"> String, one of channels_first, channels_last.</param>
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
        /// <param name="input_shape">3D tensor with shape: (batch_size, steps, input_dim)</param>
        public LocallyConnected1D(int filters, int kernel_size, int strides = 1, string padding = "valid",
            string data_format = "channels_last",
            int dilation_rate = 1, string activation = "", bool use_bias = true,
            string kernel_initializer = "glorot_uniform",
            string bias_initializer = "zeros", string kernel_regularizer = "", string bias_regularizer = "",
            string activity_regularizer = "", string kernel_constraint = "", string bias_constraint = "",
            Shape input_shape = null)
        {
            Parameters["filters"] = filters;
            Parameters["kernel_size"] = kernel_size;
            Parameters["strides"] = strides;
            Parameters["padding"] = padding;
            Parameters["data_format"] = data_format;
            Parameters["dilation_rate"] = dilation_rate;
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

            PyInstance = Instance.keras.layers.LocallyConnected1D;
            Init();
        }
    }
}