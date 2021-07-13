namespace Keras
{
    /// <summary>
    ///     Constrains the weights incident to each hidden unit to have unit norm.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class UnitNorm : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="NonNeg" /> class.
        /// </summary>
        /// <param name="axis">
        ///     integer, axis along which to calculate weight norms. For instance, in a Dense layer the weight
        ///     matrix has shape (input_dim, output_dim), set axis to 0 to constrain each weight vector of length (input_dim,). In
        ///     a Conv2D layer with data_format="channels_last", the weight tensor has shape  (rows, cols, input_depth,
        ///     output_depth), set axis to [0, 1, 2] to constrain the weights of each filter tensor of size  (rows, cols,
        ///     input_depth).
        /// </param>
        public UnitNorm(int axis = 0)
        {
            PyInstance = keras.constraints.NonNeg;
            Init();
        }
    }
}