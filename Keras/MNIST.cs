using Keras.Helper;
using Numpy;

namespace Keras
{
    /// <summary>
    ///     Dataset of 60,000 28x28 grayscale images of the 10 digits, along with a test set of 10,000 images.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class MNIST : Base
    {
        /// <summary>
        ///     Loads the data.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static ((NDarray, NDarray), (NDarray, NDarray)) LoadData(string path = "mnist.npz")
        {
            var dlist = TupleSolver.TupleToList(Instance.keras.datasets.mnist.load_data(path: path));
            return ((dlist[0], dlist[1]), (dlist[2], dlist[3]));
        }
    }
}