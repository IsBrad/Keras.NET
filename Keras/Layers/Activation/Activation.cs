using Keras.Constants;
using Keras.Interface;

namespace Keras.Layers.Activation
{
    /// <summary>
    ///     Applies an activation function to an output.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class Activation : BaseLayer, IActivationFunction
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Activation" /> class.
        /// </summary>
        /// <param name="activation">
        ///     name of activation function to use (see: activations), or alternatively, a Theano or TensorFlow
        ///     operation.
        /// </param>
        /// <param name="inputShape">
        ///     Arbitrary. Use the keyword argument inputShape (tuple of integers, does not include the
        ///     samples axis) when using this layer as the first layer in a model.
        /// </param>
        public Activation(string activation, Shape inputShape = null)
        {
            StringValue = activation;
            Parameters[KerasConstants.Activation] = activation;
            Parameters[KerasConstants.InputShape] = inputShape;
            PyInstance = Instance.keras.layers.Activation;
            Init();
        }

        public string StringValue { get; }
    }
}