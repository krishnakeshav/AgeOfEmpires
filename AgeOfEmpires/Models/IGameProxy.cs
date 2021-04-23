using AgeOfEmpires.Models;
using System.Threading.Tasks;

namespace AgeOfEmpires
{
    /// <summary>
    /// Handles request related to game information.
    /// </summary>
    public interface IGameProxy
    {
        /// <summary>
        /// Get unit information
        /// </summary>
        /// <param name="id">Unit id</param>
        /// <returns>Unit info</returns>
        Task<Unit> GetUnitInfo(int id);
    }
}
