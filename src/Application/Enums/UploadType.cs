using System.ComponentModel;

namespace CustomerManager.Application.Enums
{
    public enum UploadType : byte
    {
        
        [Description(@"Images\ProfilePictures")]
        ProfilePicture,

        [Description(@"Documents")]
        Document
    }
}