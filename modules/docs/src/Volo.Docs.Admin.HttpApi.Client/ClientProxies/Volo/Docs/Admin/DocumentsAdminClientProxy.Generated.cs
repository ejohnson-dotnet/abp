// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using Volo.Docs.Admin.Documents;
using Volo.Docs.Admin.Projects;

// ReSharper disable once CheckNamespace
namespace Volo.Docs.Admin;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IDocumentAdminAppService), typeof(DocumentsAdminClientProxy))]
public partial class DocumentsAdminClientProxy : ClientProxyBase<IDocumentAdminAppService>, IDocumentAdminAppService
{
    public virtual async Task ClearCacheAsync(ClearCacheInput input)
    {
        await RequestAsync(nameof(ClearCacheAsync), new ClientProxyRequestTypeValue
        {
            { typeof(ClearCacheInput), input }
        });
    }

    public virtual async Task PullAllAsync(PullAllDocumentInput input)
    {
        await RequestAsync(nameof(PullAllAsync), new ClientProxyRequestTypeValue
        {
            { typeof(PullAllDocumentInput), input }
        });
    }

    public virtual async Task PullAsync(PullDocumentInput input)
    {
        await RequestAsync(nameof(PullAsync), new ClientProxyRequestTypeValue
        {
            { typeof(PullDocumentInput), input }
        });
    }

    public virtual async Task<PagedResultDto<DocumentDto>> GetAllAsync(GetAllInput input)
    {
        return await RequestAsync<PagedResultDto<DocumentDto>>(nameof(GetAllAsync), new ClientProxyRequestTypeValue
        {
            { typeof(GetAllInput), input }
        });
    }

    public virtual async Task RemoveFromCacheAsync(Guid documentId)
    {
        await RequestAsync(nameof(RemoveFromCacheAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), documentId }
        });
    }

    public virtual async Task ReindexAsync(Guid documentId)
    {
        await RequestAsync(nameof(ReindexAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), documentId }
        });
    }

    public virtual async Task<List<DocumentInfoDto>> GetFilterItemsAsync()
    {
        return await RequestAsync<List<DocumentInfoDto>>(nameof(GetFilterItemsAsync));
    }

    public virtual async Task<List<ProjectWithoutDetailsDto>> GetProjectsAsync()
    {
        return await RequestAsync<List<ProjectWithoutDetailsDto>>(nameof(GetProjectsAsync));
    }
}
