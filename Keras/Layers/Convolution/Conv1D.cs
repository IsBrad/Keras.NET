namespace Keras.Layers
{
    /// <summary>
    ///     1D convolution layer (e.g. temporal convolution).
    ///     This layer creates a convolution kernel that is convolved with the layer input over a single spatial(or temporal)
    ///     dimension to produce a tensor of outputs.If use_bias is True, a bias vector is created and added to the
    ///     outputs.Finally, if activation is not None, it is applied to the outputs as well.
    ///     When using this layer as the first layer in a model, provide an input_shape argument (tuple of integers or None,
    ///     does not include the batch axis), e.g. input_shape=(10, 128) for time series sequences of 10 time steps with 128
    ///     features per step in data_format="channels_last", or (None, 128) for variable-length sequences with 128 features
    ///     per step.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class Conv1D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Conv1D" /> class.
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
        ///     Specifying any stride value != 1 is incompatible with specifying any dilation_rate value != 1.
        /// </param>
        /// <param name="padding">
        ///     One of "valid", "causal" or "same" (case-insensitive).  "valid" means "no padding". "same"
        ///     results in padding the input such that the output has the same length as the original input.  "causal" results in
        ///     causal (dilated) convolutions, e.g. output[t] does not depend on input[t + 1:]. A zero padding is used such that
        ///     the output has the same length as the original input. Useful when modeling temporal data where the model should not
        ///     violate the temporal order. See WaveNet: A Generative Model for Raw Audio, section 2.1.
        /// </param>
        /// <param name="data_format">
        ///     A string, one of "channels_last" (default) or "channels_first". The ordering of the
        ///     dimensions in the inputs.  "channels_last" corresponds to inputs with shape  (batch, steps, channels) (default
        ///     format for temporal data in Keras) while "channels_first" corresponds to inputs with shape (batch, channels,
        ///     steps).
        /// </param>
        /// <param name="dilation_rate">
        ///     an integer or tuple/list of a single integer, specifying the dilation rate to use for
        ///     dilated convolution. Currently, specifying any dilation_rate value != 1 is incompatible with specifying any strides
        ///     value != 1.
        /// </param>
        /// <param name="activation">
        ///     Activation function to use (see activations). If you don't specify anything, no activation is
        ///     applied (ie. "linear" activation: a(x) = x).
        /// </param>
        /// <param name="use_bias">Boolean, whether the layer uses a bias vector.</param>
        /// <param name="kernel_initializer">Initializer for the kernel weights matrix (see initializers).</param>
        /// <param name="bias_initializer">Initializer for the bias vector (see initializers).</param>
        /// <param name="kernel_regularizer">Regularizer function applied to the kernel weights matrix (see regularizer).</param>
        /// <param name="bias_regularizer">Regularizer function applied to the bias vector (see regularizer).</param>
        /// <param name="activity_regularizer">
        ///     Regularizer function applied to the output of the layer (its "activation"). (see
        ///     regularizer).
        /// </param>
        /// <param name="kernel_constraint"> Constraint function applied to the kernel matrix (see constraints).</param>
        /// <param name="bias_constraint">Constraint function applied to the bias vector (see constraints).</param>
        /// <param name="input_shape">3D tensor with shape: (batch, steps, channels)</param>
        public Conv1D(int filters, int kernel_size, int strides = 1, string padding = "valid",
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

            PyInstance = Instance.keras.layers.Conv1D;
            Init();
        }
    }
}