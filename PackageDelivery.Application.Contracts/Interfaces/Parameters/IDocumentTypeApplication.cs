using PackageDelivery.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDelivery.Application.Contracts.Interfaces.Parameters
{
    public interface IDocumentTypeApplication
    {
        DocumentTypeDTO getRecordById(int id);
        IEnumerable<DocumentTypeDTO> getRecordsList(string filter);
        DocumentTypeDTO createRecord(DocumentTypeDTO record);
        DocumentTypeDTO updateRecord(DocumentTypeDTO record);
        bool deleteRecordById(int id);
    }
}
