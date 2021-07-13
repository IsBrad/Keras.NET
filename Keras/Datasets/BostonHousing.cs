using Keras.Helper;
using Numpy;

namespace Keras.Datasets
{
    /// <summary>
    ///     Dataset taken from the StatLib library which is maintained at Carnegie Mellon University.
    ///     Samples contain 13 attributes of houses at different locations around the Boston suburbs in the late 1970s.Targets
    ///     are the median values of the houses at a location(in k$).
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class BostonHousing : Base
    {
        /// <summary>
        ///     Loads the data.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="test_split">The test split.</param>
        /// <param name="seed">The seed.</param>
        /// <returns></returns>
        public static ((NDarray, NDarray), (NDarray, NDarray)) LoadData(string path = "boston_housing.npz",
            float test_split = 0.2f, int seed = 113)
        {
            var dlist = TupleSolver.TupleToList(
                Instance.keras.datasets.boston_housing.load_data(path: path, test_split: test_split, seed: seed));
            return ((dlist[0], dlist[1]), (dlist[2], dlist[3]));
        }
    }
}