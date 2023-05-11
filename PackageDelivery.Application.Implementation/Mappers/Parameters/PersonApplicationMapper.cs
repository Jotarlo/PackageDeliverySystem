
using PackageDelivery.Application.DTO;
using PackageDelivery.Repository.DbModels.Parameters;
using System.Collections.Generic;

namespace PackageDelivery.Application.Implementation.Mappers.Parameters
{
    public class PersonApplicationMapper : DTOMapperBase<PersonDTO, PersonDbModel>
    {
        public override PersonDTO DbModelToDTOMapper(PersonDbModel input)
        {
            return new PersonDTO()
            {
                Id = input.Id,
                FirstName = input.FirstName,
                OtherNames = input.OtherNames,
                FirstLastname = input.FirstLastname,
                SecondLastname = input.SecondLastname,
                Cellphone = input.Cellphone,
                Email = input.Email,
                IdentificationNumber = input.IdentificationNumber,
                IdentificationType = input.IdentificationType,
                DocumentTypeName = input.DocumentTypeName
            };
        }

        public override IEnumerable<PersonDTO> DbModelToDTOMapper(IEnumerable<PersonDbModel> input)
        {
            IList<PersonDTO> list = new List<PersonDTO>();
            foreach (var item in input)
            {
                list.Add(this.DbModelToDTOMapper(item));
            }
            return list;
        }

        public override PersonDbModel DTOToDbModelMapper(PersonDTO input)
        {
            return new PersonDbModel()
            {
                Id = input.Id,
                FirstName = input.FirstName,
                OtherNames = input.OtherNames,
                FirstLastname = input.FirstLastname,
                SecondLastname = input.SecondLastname,
                Cellphone = input.Cellphone,
                Email = input.Email,
                IdentificationNumber = input.IdentificationNumber,
                IdentificationType = input.IdentificationType
            };
        }

        public override IEnumerable<PersonDbModel> DTOToDbModelMapper(IEnumerable<PersonDTO> input)
        {
            IList<PersonDbModel> list = new List<PersonDbModel>();
            foreach (var item in input)
            {
                list.Add(this.DTOToDbModelMapper(item));
            }
            return list;
        }
    }
}
