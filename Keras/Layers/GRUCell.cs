namespace Keras.Layers
{
    /// <summary>
    ///     Cell class for the GRU layer.
    /// </summary>
    /// <seealso cref="Keras.Layers.RNN" />
    public class GRUCell : RNN
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GRUCell" /> class.
        /// </summary>
        /// <param name="units"> Positive integer, dimensionality of the output space.</param>
        /// <param name="activation">
        ///     Activation function to use (see activations). Default: hyperbolic tangent (tanh). If you pass
        ///     None, no activation is applied (ie. "linear" activation: a(x) = x).
        /// </param>
        /// <param name="recurrent_activation">
        ///     Activation function to use for the recurrent step (see activations). Default: hard
        ///     sigmoid (hard_sigmoid). If you pass None, no activation is applied (ie. "linear" activation: a(x) = x).
        /// </param>
        /// <param name="use_bias"> Boolean, whether the layer uses a bias vector.</param>
        /// <param name="kernel_initializer">
        ///     Initializer for the kernel weights matrix, used for the linear transformation of the
        ///     inputs (see initializers).
        /// </param>
        /// <param name="recurrent_initializer">
        ///     Initializer for the recurrent_kernel weights matrix, used for the linear
        ///     transformation of the recurrent state (see initializers).
        /// </param>
        /// <param name="bias_initializer"> Initializer for the bias vector (see initializers).</param>
        /// <param name="kernel_regularizer"> Regularizer function applied to the kernel weights matrix (see regularizer).</param>
        /// <param name="recurrent_regularizer">
        ///     Regularizer function applied to the recurrent_kernel weights matrix (see
        ///     regularizer).
        /// </param>
        /// <param name="bias_regularizer"> Regularizer function applied to the bias vector (see regularizer).</param>
        /// <param name="activity_regularizer">
        ///     Regularizer function applied to the output of the layer (its "activation"). (see
        ///     regularizer).
        /// </param>
        /// <param name="kernel_constraint"> Constraint function applied to the kernel weights matrix (see constraints).</param>
        /// <param name="recurrent_constraint">
        ///     Constraint function applied to the recurrent_kernel weights matrix (see
        ///     constraints).
        /// </param>
        /// <param name="bias_constraint"> Constraint function applied to the bias vector (see constraints).</param>
        /// <param name="dropout">
        ///     Float between 0 and 1. Fraction of the units to drop for the linear transformation of the
        ///     inputs.
        /// </param>
        /// <param name="recurrent_dropout">
        ///     Float between 0 and 1. Fraction of the units to drop for the linear transformation of
        ///     the recurrent state.
        /// </param>
        /// <param name="implementation">
        ///     Implementation mode, either 1 or 2. Mode 1 will structure its operations as a larger
        ///     number of smaller dot products and additions, whereas mode 2 will batch them into fewer, larger operations. These
        ///     modes will have different performance profiles on different hardware and for different applications.
        /// </param>
        /// <param name="reset_after">
        ///     GRU convention (whether to apply reset gate after or before matrix multiplication). False =
        ///     "before" (default), True = "after" (CuDNN compatible).
        /// </param>
        public GRUCell(int units, string activation = "tanh", string recurrent_activation = "hard_sigmoid",
            bool use_bias = true, string kernel_initializer = "glorot_uniform"
            , string recurrent_initializer = "orthogonal", string bias_initializer = "zeros",
            string kernel_regularizer = "", string recurrent_regularizer = "",
            string bias_regularizer = "", string activity_regularizer = "", string kernel_constraint = "",
            string recurrent_constraint = "", string bias_constraint = "",
            float dropout = 0.0f, float recurrent_dropout = 0.0f, int implementation = 1, bool reset_after = false)
        {
            Parameters["units"] = units;
            Parameters["activation"] = activation;
            Parameters["recurrent_activation"] = recurrent_activation;
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
            Parameters["implementation"] = implementation;
            Parameters["reset_after"] = reset_after;
            PyInstance = Instance.keras.layers.GRUCell;
            Init();
        }
    }
}