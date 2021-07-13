namespace Keras.Layers
{
    /// <summary>
    ///     Parametric Rectified Linear Unit.
    ///     It follows: f(x) = alpha* x for x< 0, f( x)= x for x>= 0, where alpha is a learned array with the same shape as x.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class PReLU : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PReLU" /> class.
        /// </summary>
        /// <param name="alpha_initializer">initializer function for the weights.</param>
        /// <param name="alpha_regularizer">regularizer for the weights.</param>
        /// <param name="alpha_constraint">constraint for the weights.</param>
        /// <param name="shared_axes">
        ///     the axes along which to share learnable parameters for the activation function. For example,
        ///     if the incoming feature maps are from a 2D convolution with output shape (batch, height, width, channels), and you
        ///     wish to share parameters across space so that each filter only has one set of parameters, set shared_axes=[1, 2].
        /// </param>
        public PReLU(string alpha_initializer = "zeros", string alpha_regularizer = "", string alpha_constraint = "",
            int[] shared_axes = null)
        {
            Parameters["alpha_initializer"] = alpha_initializer;
            Parameters["alpha_regularizer"] = alpha_regularizer;
            Parameters["alpha_constraint"] = alpha_constraint;
            Parameters["shared_axes"] = shared_axes;

            PyInstance = Instance.keras.layers.PReLU;
            Init();
        }
    }
}