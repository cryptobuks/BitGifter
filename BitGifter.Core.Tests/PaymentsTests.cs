using System;
using Xunit;
using BitGifter.Core.Cross_Cutting;
using BitGifter.Core.BitWallet;

namespace BitGifter.Core.Tests
{
    public class PaymentsTests
    {
        [Fact]
        public void Shoud_Be_Able_To_Transfer_BitCoins()
        {
            var amount_to_send = 0.00926637m.BtcToSatoshi(); //10 eur;                                                            

            var walletService = new WalletService();

            var waletResponse = walletService.CreateWallet(new WalletRequest { customer = new BitWallet.Customer { id = "artur_test" } });
            var paymentResult = walletService.MakePayment(new PaymentRequest { customer = new BitWallet.Customer { id = "artur_test" }, transfer = new Transfer { amount = amount_to_send, to = "1CErEKqgtJ3wmQaF2Kt9YnNVKuBofGWjv4" } });
        }
    }
}