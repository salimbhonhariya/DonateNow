using DonateNow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonateNow.Services
{
    public interface Idonor
    {
        bool CreateDonor();
        List<Donor> ListDonors();
        bool DeleteDonor(int DonorId);
        Donor EditDonor(Donor donor);

    }
}
