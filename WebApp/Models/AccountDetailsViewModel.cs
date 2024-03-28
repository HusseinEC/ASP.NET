using Infrastructure.Entities;

namespace WebApp.Models;

public class AccountDetailsViewModel
{
    public ProfileInfoViewModel? ProfileInfo { get; set; }
    public BasicInfoFormViewModel? BasicInfoForm { get; set; }
    public AddressInfoFormViewModel? AddressInfoForm { get; set; }
}
