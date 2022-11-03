# ASP.NET Core 7 Localization Sample

> **Info** 
> Current as of November 3rd, 2022.

This sample uses the `RequestLocalizationMiddleware` to set the current request
threads `CurrentCulture` and `CurrentCultureUI` properties. This allows you to switch between supported languages.

**Localiations is a feature that should work with previous versions of ASP.NET Core, so feel free to change the target framework to a lower version.**

All localization is managed in `.resx` files under the [Resources](./TestBed/Resources) directory. This sample has two languages of English and Spanish. I apologize in advance to Spanish-speaking folks if the translations are bad. I accept pull requests :).

This project also uses the [`Localization.AspNetCore.TagHelpers`](https://www.nuget.org/packages/Localization.AspNetCore.TagHelpers) to make localizing ASP.NET Core Razor Pages much easier. It provides a `localize` tag that uses the contents of the element as a key to search through resources. It also supports HTML strings from your resources (pretty sweet).

```html
<h1 class="display-4">
    <localize>Welcome</localize>
</h1>
<p>
    <localize html="true">Learn</localize>
</p>
```

Give it a try and let me know if you have any questions. As always, please feel free to follow me on Twitter at [@buhakmeh](https://twitter.com/buhakmeh) and ask any questions.

🍻Cheers! 

-- Khalid