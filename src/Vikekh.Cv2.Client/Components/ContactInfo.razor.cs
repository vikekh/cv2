using Microsoft.AspNetCore.Components;

namespace Vikekh.Cv2.Client.Components;

public partial class ContactInfo : ComponentBase
{
    [EditorRequired, Parameter]
    public IContactInfoViewModel ViewModel { get; set; } = null!;
}
