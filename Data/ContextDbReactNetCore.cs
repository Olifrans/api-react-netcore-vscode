using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using api_react_netcore_vscode.Models;

namespace api_react_netcore_vscode.Data;

public class ContextDbReactNetCore : DbContext
{
    public ContextDbReactNetCore(DbContextOptions<ContextDbReactNetCore> options) : base(options)
    {
    }
    public DbSet<Note>? Notes { get; set; }
}