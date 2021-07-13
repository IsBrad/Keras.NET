using System.Collections.Generic;
using Numpy;

namespace Keras.Layers
{
    /// <summary>
    ///     Wraps arbitrary expression as a Layer object.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class Lambda : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Lambda" /> class.
        /// </summary>
        /// <param name="function">The function to be evaluated. Takes input tensor or list of tensors as first argument.</param>
        /// <param name="output_shape">
        ///     Expected output shape from function. Only relevant when using Theano. Can be a tuple or
        ///     function. If a tuple, it only specifies the first dimension onward; sample dimension is assumed either the same as
        ///     the input:  output_shape = (input_shape[0], ) + output_shape or, the input is None and the sample dimension is also
        ///     None:  output_shape = (None, ) + output_shape If a function, it specifies the entire shape as a function of the
        ///     input shape: output_shape = f(input_shape)
        /// </param>
        /// <param name="mask">Either None (indicating no masking) or a Tensor indicating the input mask for Embedding.</param>
        /// <param name="arguments">optional dictionary of keyword arguments to be passed to the function.</param>
        /// <param name="input_shape">
        ///     Arbitrary. Use the keyword argument input_shape (tuple of integers, does not include the
        ///     samples axis) when using this layer as the first layer in a model.
        /// </param>
        public Lambda(object function, Shape output_shape = null, NDarray mask = null,
            Dictionary<string, object> arguments = null, Shape input_shape = null)
        {
            Parameters["function"] = function;
            Parameters["output_shape"] = output_shape;
            Parameters["mask"] = mask;
            Parameters["arguments"] = arguments;
            Parameters["input_shape"] = input_shape;

            PyInstance = Instance.keras.layers.Lambda;
            Init();
        }
    }
}