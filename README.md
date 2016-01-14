# owin-role-provider
Owin middleware to inject role claims into an identity.

## Usage
Add this middleware to your `Startup.cs` (or equivalent) using:

```C#
app.UseOwinRoleProvider(new MyRoleProvider())
```

The Role Provider interface, `IRoleProvider`, exposes one method `GetRolesForUser(string identifier)`.
Wrap your role service in it, to allow these roles to be added to the Owin ClaimsIdentity.
