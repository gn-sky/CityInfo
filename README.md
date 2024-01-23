<h1>Sample ASP.NET Core 8 Web API</h1>
<p>Routing middleware is added to the request pipeline & <code>attribute routing</code> is used.</p>
<p>API gets & manipulates data from API endpoints, using the built-in dependency injection system. Endpoints are decorated with appropriate <code>Http</code> attributes: Get, Post, Patch, etc…</p>
<p>Endpoints return <code>async Task</code>s to free up threads to be used for other tasks, improving the application's scalability.</p>
<p><code>ICityInfoRepository.cs</code>: Repository Pattern is implemented.</p>
<p><code>Automapper</code> is used to map between <code>Entites</code> & <code>DTOs</code> (<code>Profiles</code> folder).</p>
<p>Check <code>GetCitiesAsync(string? name, string? searchQuery, int pageNumber, int pageSize)</code> for searching & paging.
<p><code>IQueryable<T></code> is used for deferred execution: query is constructed with passed filters & executed in the end when iterated over with <code>ToListAsync()</code>.
<p>Connects to <code>SQL</code> database via <code>Entity Framework Core 8</code> with code-first approach.
<p>API is documented with <code>Swagger</code>.<code>XML comments</code> are used to make it more descriptive: <code>Response Types</code> & <code>Status Codes</code>. (Check <code>GetCity</code> endpoint in <code>CitiesController.cs</code> for a sample.)</p>
<p><code>CityInfoApiBearerAuth</code> security definition (<code>type: “Http”, scheme: “Bearer”</code>) is required (check <code>builder.Services.AddSwaggerGen</code> in <code>Program.cs</code>). Sample <code>jwt</code> is generated in <code>AuthenticationController.cs</code>.</p>
<p>Versioning via URI.</p>
