namespace Keras.Layers
{
    /// <summary>
    ///     Just your regular densely-connected NN layer.
    ///     Dense implements the operation: output = activation(dot(input, kernel) + bias) where activation is the element-wise
    ///     activation function passed as the activation argument, kernel is a weights matrix created by the layer, and bias is
    ///     a bias vector created by the layer(only applicable if use_bias is True).
    ///     Note: if the input to the layer has a rank greater than 2, then it is flattened prior to the initial dot product
    ///     with kernel.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class Dense : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Dense" /> class.
        /// </summary>
        /// <param name="units"> Positive integer, dimensionality of the output space.</param>
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
        /// <param name="kernel_constraint"> Constraint function applied to the kernel weights matrix (see constraints).</param>
        /// <param name="bias_constraint"> Constraint function applied to the bias vector (see constraints).</param>
        /// <param name="input_shape">
        ///     nD tensor with shape: (batch_size, ..., input_dim). The most common situation would be a 2D
        ///     input with shape (batch_size, input_dim).
        /// </param>
        public Dense(int units, int? input_dim = null, string activation = "", bool use_bias = true,
            StringOrInstance kernel_initializer = null,
            string bias_initializer = "zeros", StringOrInstance kernel_regularizer = null, string bias_regularizer = "",
            string activity_regularizer = "", string kernel_constraint = "", string bias_constraint = "",
            Shape input_shape = null)
        {
            this["units"] = units;
            this["input_dim"] = input_dim;
            this["activation"] = activation;
            this["use_bias"] = use_bias;
            this["kernel_initializer"] = kernel_initializer ?? "glorot_uniform";
            this["bias_initializer"] = bias_initializer;
            this["kernel_regularizer"] = kernel_regularizer;
            this["bias_regularizer"] = bias_regularizer;
            this["activity_regularizer"] = activity_regularizer;
            this["kernel_constraint"] = kernel_constraint;
            this["bias_constraint"] = bias_constraint;
            Parameters["input_shape"] = input_shape;
            PyInstance = Instance.keras.layers.Dense;
            Init();
        }
    }
}