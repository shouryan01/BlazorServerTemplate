using Microsoft.AspNetCore.Identity;

namespace BlazorServerTemplate.Data {
    public class BlazorUser : IdentityUser
    {
        [PersonalData]
        public int ? Age { get; set; }
        [PersonalData]
        public string ? Address { get; set; }
    }
}
