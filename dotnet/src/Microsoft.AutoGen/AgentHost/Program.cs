// Copyright (c) Microsoft Corporation. All rights reserved.
// Program.cs

using Microsoft.AutoGen.Agents;
var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
builder.AddLocalAgentService();

var app = builder.Build();

app.MapDefaultEndpoints();
app.MapAgentService();

app.Run();