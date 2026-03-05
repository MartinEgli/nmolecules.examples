using NMolecules.DDD;

namespace Samples.Block07.DddFromPdfs.AuthorRefinement;

[AggregateRoot]
public sealed class Forum
{
    public Forum(ForumId id)
    {
        Id = id;
    }

    [Identity]
    public ForumId Id { get; }

    public Discussion StartDiscussion(Author author, string subject)
    {
        return new Discussion(new DiscussionId(Guid.NewGuid().ToString("N")), author, subject);
    }
}

[AggregateRoot]
public sealed class Discussion
{
    public Discussion(DiscussionId id, Author author, string subject)
    {
        Id = id;
        Author = author;
        Subject = subject;
    }

    [Identity]
    public DiscussionId Id { get; }

    public Author Author { get; }

    public string Subject { get; }
}

[ValueObject]
public readonly record struct ForumId(string Value);

[ValueObject]
public readonly record struct DiscussionId(string Value);

// Derived from IDDD p.119-121: introduce explicit Author value object.
[ValueObject]
public readonly record struct Author(string UserId, string DisplayName, string EmailAddress);

[Repository]
public interface IDiscussionRepository
{
    void Add(Discussion discussion);
}

[ApplicationService]
public sealed class ForumApplicationService
{
    private readonly IDiscussionRepository _discussionRepository;
    private readonly IForumRepository _forumRepository;

    public ForumApplicationService(IDiscussionRepository discussionRepository, IForumRepository forumRepository)
    {
        _discussionRepository = discussionRepository;
        _forumRepository = forumRepository;
    }

    public Discussion StartDiscussion(ForumId forumId, Author author, string subject)
    {
        var forum = _forumRepository.GetById(forumId) ?? throw new InvalidOperationException("Forum does not exist.");
        var discussion = forum.StartDiscussion(author, subject);
        _discussionRepository.Add(discussion);
        return discussion;
    }
}

[Repository]
public interface IForumRepository
{
    Forum? GetById(ForumId id);
}
