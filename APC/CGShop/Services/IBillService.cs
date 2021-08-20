using System.Collections.Generic;

namespace CGShop
{
    interface IBillService
    {
        Bill Find (int billId, bool isPaid = false);
        bool CreateBill(List<BillDetail> BillDetails);
    }
}