namespace PackageDelivery.Repository.Contracts.DbModels.Parameters
{
    public class PersonDbModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string OtherNames { get; set; }
        public string FirstLastname { get; set; }
        public string SecondLastname { get; set; }
        public string IdentificationNumber { get; set; }
        public string cellphone { get; set; }
        public string email { get; set; }
        public int IdentificationType { get; set; }

    }
}
