// ------------------------------------------------------------------------
// MIT License - Copyright (c) Microsoft Corporation. All rights reserved.
// ------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;

namespace FluentUI.Demo.Client;

/// <summary />
public class HttpBasedStaticAssetService : IStaticAssetService
{
    private readonly HttpClient _httpClient;

    /// <summary />
    public HttpBasedStaticAssetService(HttpClient httpClient, NavigationManager navigationManager)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress ??= new Uri(navigationManager.BaseUri);
    }

    /// <summary />
    public async Task<string?> GetAsync(string assetUrl, bool useCache = true)
    {
        string? result = null;

        useCache = false; // TODO: Remove this line when the cache is implemented

        var message = CreateMessage(assetUrl);

        if (useCache)
        {
            // Get the result from the cache
            // result = await _cacheStorageAccessor.GetAsync(message);
        }

        if (string.IsNullOrEmpty(result))
        {
            //It not in the cache (or cache not used), download the asset
            var response = await _httpClient.SendAsync(message);

            // If successful, store the response in the cache and get the result
            if (response.IsSuccessStatusCode)
            {
                if (useCache)
                {
                    // Store the response in the cache and get the result
                    // result = await _cacheStorageAccessor.PutAndGetAsync(message, response);
                }
                else
                {
                    result = await response.Content.ReadAsStringAsync();
                }
            }
            else
            {
                result = string.Empty;
            }
        }

        return result;
    }

    /// <summary />
    private static HttpRequestMessage CreateMessage(string url) => new(HttpMethod.Get, url);
}
