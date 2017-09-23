namespace NaiveCoin.Wallets.Tests.Fixtures
{
    public class WalletWithTwoAddressesFixture
    {
        public WalletWithTwoAddressesFixture()
        {
            var factory = new FixedSaltWalletFactoryProvider("salt");
            var provider = new WalletAddressProviderFixture();
            var wallet = factory.Create("rosebud");

            provider.Value.GenerateAddress(wallet);
            provider.Value.GenerateAddress(wallet);

            Value = wallet;
        }

        public Wallet Value { get; set; }
    }
}