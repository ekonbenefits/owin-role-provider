# owin-role-provider-ekon-fork
Owin middleware to inject role claims into an identity.

## Usage
Add this middleware to your `Startup.cs` (or equivalent) using:

```C#
app.UseOwinRoleProvider(new MyRoleProvider())
```

The Role Provider interface, `IRoleProvider`, exposes one method `GetRolesForUser(IPrincipal identifier)`.
Wrap your role service in it, to allow these roles to be added to the Owin ClaimsIdentity.
