
using PackageDelivery.Application.DTO;
using PackageDelivery.GUI.Models.Parameters;
using System.Collections.Generic;

namespace PackageDelivery.GUI.Implementation.Mappers.Parameters
{
    public class PersonGUIMapper : ModelMapperBase<PersonModel, PersonDTO>
    {
        public override PersonModel DTOToModelMapper(PersonDTO input)
        {
            return new PersonModel()
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

        public override IEnumerable<PersonModel> DTOToModelMapper(IEnumerable<PersonDTO> input)
        {
            IList<PersonModel> list = new List<PersonModel>();
            foreach (var item in input)
            {
                list.Add(this.DTOToModelMapper(item));
            }
            return list;
        }

        public override PersonDTO ModelToDTOMapper(PersonModel input)
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
                IdentificationType = input.IdentificationType
            };
        }

        public override IEnumerable<PersonDTO> ModelToDTOMapper(IEnumerable<PersonModel> input)
        {
            IList<PersonDTO> list = new List<PersonDTO>();
            foreach (var item in input)
            {
                list.Add(this.ModelToDTOMapper(item));
            }
            return list;
        }
    }
}
