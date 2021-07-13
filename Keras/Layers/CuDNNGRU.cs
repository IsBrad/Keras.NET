namespace Keras.Layers
{
    /// <summary>
    ///     Fast GRU implementation backed by CuDNN. Can only be run on GPU, with the TensorFlow backend.
    /// </summary>
    /// <seealso cref="Keras.Layers.RNN" />
    public class CuDNNGRU : RNN
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CuDNNGRU" /> class.
        /// </summary>
        /// <param name="units">Positive integer, dimensionality of the output space.</param>
        /// <param name="kernel_initializer">
        ///     Initializer for the kernel weights matrix, used for the linear transformation of the
        ///     inputs (see initializers).
        /// </param>
        /// <param name="recurrent_initializer">
        ///     Initializer for the recurrent_kernel weights matrix, used for the linear
        ///     transformation of the recurrent state (see initializers).
        /// </param>
        /// <param name="bias_initializer">Initializer for the bias vector (see initializers).</param>
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
        /// <param name="return_sequences">Boolean. Whether to return the last output in the output sequence, or the full sequence.</param>
        /// <param name="return_state">Boolean. Whether to return the last state in addition to the output.</param>
        /// <param name="stateful">
        ///     Boolean (default False). If True, the last state for each sample at index i in a batch will be
        ///     used as initial state for the sample of index i in the following batch.
        /// </param>
        public CuDNNGRU(int units, string kernel_initializer = "glorot_uniform",
            string recurrent_initializer = "orthogonal", string bias_initializer = "zeros",
            string kernel_regularizer = "", string recurrent_regularizer = "",
            string bias_regularizer = "", string activity_regularizer = "", string kernel_constraint = "",
            string recurrent_constraint = "", string bias_constraint = "",
            bool return_sequences = false, bool return_state = false, bool stateful = false)
        {
            Parameters["units"] = units;
            Parameters["kernel_initializer"] = kernel_initializer;
            Parameters["recurrent_initializer"] = recurrent_initializer;
            Parameters["bias_initializer"] = bias_initializer;
            Parameters["kernel_regularizer"] = kernel_regularizer;
            Parameters["recurrent_regularizer"] = recurrent_regularizer;
            Parameters["bias_regularizer"] = bias_regularizer;
            Parameters["activity_regularizer"] = activity_regularizer;
            Parameters["kernel_constraint"] = kernel_constraint;
            Parameters["recurrent_constraint"] = recurrent_constraint;
            Parameters["bias_constraint"] = bias_constraint;
            Parameters["return_sequences"] = return_sequences;
            Parameters["return_state"] = return_state;
            Parameters["stateful"] = stateful;
            PyInstance = Instance.keras.layers.CuDNNGRU;
            Init();
        }
    }
}