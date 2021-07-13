namespace Keras
{
    /// <summary>
    ///     MaxNorm weight constraint.
    ///     Constrains the weights incident to each hidden unit to have a norm less than or equal to a desired value.
    /// </summary>
    public class MaxNorm : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MaxNorm" /> class.
        /// </summary>
        /// <param name="max_value">the maximum norm for the incoming weights.</param>
        /// <param name="axis">
        ///     integer, axis along which to calculate weight norms. For instance, in a Dense layer the weight
        ///     matrix has shape (input_dim, output_dim), set axis to 0 to constrain each weight vector of length (input_dim,). In
        ///     a Conv2D layer with data_format="channels_last", the weight tensor has shape  (rows, cols, input_depth,
        ///     output_depth), set axis to [0, 1, 2] to constrain the weights of each filter tensor of size  (rows, cols,
        ///     input_depth).
        /// </param>
        public MaxNorm(float max_value = 2, int axis = 0)
        {
            Parameters["max_value"] = max_value;
            Parameters["axis"] = axis;

            PyInstance = keras.constraints.MaxNorm;
            Init();
        }
    }
}