using Microsoft.AspNetCore.Identity;

namespace api_react_netcore_vscode.Models;

public class Note
{
    public int Id { get; set; }
    public string? Titlo { get; set; }
    public string? Descricao { get; set; }
}
