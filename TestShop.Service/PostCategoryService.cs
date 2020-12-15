using System.Collections.Generic;
using TestShop.Data.Infrastructure;
using TestShop.Data.Repositories;
using TestShop.Model.Models;

namespace TestShop.Service
{
    public interface IPostCategoryService
    {
        void Add(PostCategory postCategory);

        void UpDate(PostCategory postCategory);

        void Delete(int id);

        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GetByParentId(int parentId);

        PostCategory GetById(int id);
    }

    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRepository _postCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(PostCategory postCategory)
        {
            _postCategoryRepository.Add(postCategory);
        }

        public void Delete(int id)
        {
            _postCategoryRepository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public PostCategory GetById(int id)
        {
            return _postCategoryRepository.GetSingleById(id);
        }

        public IEnumerable<PostCategory> GetByParentId(int parentId)
        {
            return _postCategoryRepository.GetMulti(X => X.Status && X.ParentID == parentId);
        }

        public void UpDate(PostCategory postCategory)
        {
            _postCategoryRepository.Update(postCategory);
        }
    }
}