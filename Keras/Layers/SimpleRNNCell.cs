namespace Keras.Layers
{
    /// <summary>
    ///     Cell class for SimpleRNN.
    /// </summary>
    /// <seealso cref="Keras.Layers.RNN" />
    public class SimpleRNNCell : RNN
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SimpleRNNCell" /> class.
        /// </summary>
        /// <param name="units">Positive integer, dimensionality of the output space.</param>
        /// <param name="activation">
        ///     Activation function to use (see activations). Default: hyperbolic tangent (tanh). If you pass
        ///     None, no activation is applied (ie. "linear" activation: a(x) = x).
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
        public SimpleRNNCell(int units, string activation = "tanh", bool use_bias = true,
            string kernel_initializer = "glorot_uniform", string recurrent_initializer = "orthogonal"
            , string bias_initializer = "zeros", string kernel_regularizer = "", string recurrent_regularizer = "",
            string bias_regularizer = "",
            string activity_regularizer = "", string kernel_constraint = "", string recurrent_constraint = "",
            string bias_constraint = "", float dropout = 0.0f, float recurrent_dropout = 0.0f)
        {
            Parameters["units"] = units;
            Parameters["activation"] = activation;
            Parameters["use_bias"] = use_bias;
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
            Parameters["dropout"] = dropout;
            Parameters["recurrent_dropout"] = recurrent_dropout;
            PyInstance = Instance.keras.layers.SimpleRNNCell;
            Init();
        }
    }
}