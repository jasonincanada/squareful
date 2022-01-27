## Parameter Changes on Same Route

When clicking on a `NavLink` component that leaves the overall route the same but changes the parameters, the components are not automatically updated. You have to override `OnParametersSetAsync()`:

```csharp
protected override async Task OnInitializedAsync()
{
	string url = $"boards/{ID}.txt";
	string sequenceData = await Http.GetStringAsync(url);

	Sequence = sequenceData.Substring(0, 36);
}

protected override async Task OnParametersSetAsync()
{
	await OnInitializedAsync();
}
```

Or synchronously, as in `Board.razor`:

```csharp
protected override void OnInitialized()
{
    BoardData = new Model.Board(Sequence);
}

protected override void OnParametersSet()
{
    OnInitialized();
}
```


## Notes

From [Razor Component vs Razor Page](https://stackoverflow.com/questions/65773674/razor-component-vs-razor-page):
- Notice that when you add `@page` directive to a Blazor component it becomes enroutable (like a "blazor page"), but it is still a component.
