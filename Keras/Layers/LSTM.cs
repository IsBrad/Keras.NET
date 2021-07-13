namespace Keras.Layers
{
    /// <summary>
    ///     Long Short-Term Memory layer - Hochreiter 1997.
    /// </summary>
    public class LSTM : RNN
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LSTM" /> class.
        /// </summary>
        /// <param name="units">Positive integer, dimensionality of the output space.</param>
        /// <param name="activation">
        ///     Activation function to use (see activations). Default: hyperbolic tangent (tanh). If you pass
        ///     None, no activation is applied (ie. "linear" activation: a(x) = x).
        /// </param>
        /// <param name="recurrent_activation">
        ///     Activation function to use for the recurrent step (see activations). Default: hard
        ///     sigmoid (hard_sigmoid). If you pass None, no activation is applied (ie. "linear" activation: a(x) = x).
        /// </param>
        /// <param name="use_bias">Boolean, whether the layer uses a bias vector.</param>
        /// <param name="kernel_initializer">
        ///     Initializer for the kernel weights matrix, used for the linear transformation of the
        ///     inputs (see initializers).
        /// </param>
        /// <param name="recurrent_initializer">
        ///     Initializer for the recurrent_kernel weights matrix, used for the linear
        ///     transformation of the recurrent state (see initializers).
        /// </param>
        /// <param name="bias_initializer">Initializer for the bias vector (see initializers).</param>
        /// <param name="unit_forget_bias">if set to <c>true</c> [unit forget bias].</param>
        /// <param name="kernel_regularizer">Regularizer function applied to the kernel weights matrix (see regularizer).</param>
        /// <param name="recurrent_regularizer">
        ///     Regularizer function applied to the recurrent_kernel weights matrix (see
        ///     regularizer).
        /// </param>
        /// <param name="bias_regularizer">Regularizer function applied to the bias vector (see regularizer).</param>
        /// <param name="activity_regularizer">
        ///     Regularizer function applied to the output of the layer (its "activation"). (see
        ///     regularizer).
        /// </param>
        /// <param name="kernel_constraint">Constraint function applied to the kernel weights matrix (see constraints).</param>
        /// <param name="recurrent_constraint">
        ///     Constraint function applied to the recurrent_kernel weights matrix (see
        ///     constraints).
        /// </param>
        /// <param name="bias_constraint">Constraint function applied to the bias vector (see constraints).</param>
        /// <param name="dropout">Float between 0 and 1. Fraction of the units to drop for the linear transformation of the inputs.</param>
        /// <param name="recurrent_dropout">
        ///     Float between 0 and 1. Fraction of the units to drop for the linear transformation of
        ///     the recurrent state.
        /// </param>
        /// <param name="implementation">
        ///     Implementation mode, either 1 or 2. Mode 1 will structure its operations as a larger
        ///     number of smaller dot products and additions, whereas mode 2 will batch them into fewer, larger operations. These
        ///     modes will have different performance profiles on different hardware and for different applications.
        /// </param>
        /// <param name="return_sequences">Boolean. Whether to return the last output in the output sequence, or the full sequence.</param>
        /// <param name="return_state">Boolean. Whether to return the last state in addition to the output.</param>
        /// <param name="go_backwards">
        ///     Boolean (default False). If True, process the input sequence backwards and return the
        ///     reversed sequence.
        /// </param>
        /// <param name="stateful">
        ///     Boolean (default False). If True, the last state for each sample at index i in a batch will be
        ///     used as initial state for the sample of index i in the following batch.
        /// </param>
        /// <param name="unroll">
        ///     Boolean (default False). If True, the network will be unrolled, else a symbolic loop will be used.
        ///     Unrolling can speed-up a RNN, although it tends to be more memory-intensive. Unrolling is only suitable for short
        ///     sequences.
        /// </param>
        /// <param name="batch_input_shape">Optional input batch size (integer or None).</param>
        public LSTM(int units, string activation = "tanh", string recurrent_activation = "hard_sigmoid",
            bool use_bias = true, StringOrInstance kernel_initializer = null
            , StringOrInstance recurrent_initializer = null, string bias_initializer = "zeros",
            bool unit_forget_bias = true, string kernel_regularizer = "",
            string recurrent_regularizer = "", string bias_regularizer = "", string activity_regularizer = "",
            string kernel_constraint = "", string recurrent_constraint = "",
            string bias_constraint = "", float dropout = 0.0f, float recurrent_dropout = 0.0f, int implementation = 1,
            bool return_sequences = false, bool return_state = false,
            bool go_backwards = false, bool stateful = false, bool unroll = false, Shape batch_input_shape = null,
            Shape input_shape = null)
        {
            Parameters["units"] = units;
            Parameters["activation"] = activation;
            Parameters["recurrent_activation"] = recurrent_activation;
            Parameters["use_bias"] = use_bias;
            Parameters["kernel_initializer"] = kernel_initializer;
            Parameters["recurrent_initializer"] = recurrent_initializer;
            Parameters["bias_initializer"] = bias_initializer;
            Parameters["unit_forget_bias"] = unit_forget_bias;
            Parameters["kernel_regularizer"] = kernel_regularizer;
            Parameters["recurrent_regularizer"] = recurrent_regularizer;
            Parameters["bias_regularizer"] = bias_regularizer;
            Parameters["activity_regularizer"] = activity_regularizer;
            Parameters["kernel_constraint"] = kernel_constraint;
            Parameters["recurrent_constraint"] = recurrent_constraint;
            Parameters["bias_constraint"] = bias_constraint;
            Parameters["dropout"] = dropout;
            Parameters["recurrent_dropout"] = recurrent_dropout;
            Parameters["implementation"] = implementation;
            Parameters["return_sequences"] = return_sequences;
            Parameters["return_state"] = return_state;
            Parameters["go_backwards"] = go_backwards;
            Parameters["stateful"] = stateful;
            Parameters["unroll"] = unroll;

            if (batch_input_shape != null)
                Parameters["batch_input_shape"] = batch_input_shape;
            else if (input_shape != null) Parameters["input_shape"] = input_shape;

            PyInstance = Instance.keras.layers.LSTM;
            Init();
        }
    }
}