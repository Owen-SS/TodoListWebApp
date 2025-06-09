using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class UsersModel : PageModel
{
    private readonly UserManager<IdentityUser> _userManager;

    public UsersModel(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public IList<IdentityUser> Users { get; set; }

    public void OnGet()
    {
        Users = _userManager.Users.ToList();
    }
}
