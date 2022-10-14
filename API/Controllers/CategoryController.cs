using Application.Features.Dtos.Category;
using Application.Services.Interfaces;
using AutoMapper;
using Common.BaseController;
using Common.Dtos;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryDto createCategoryDto)
        {
            var category = _mapper.Map<Category>(createCategoryDto);
            var result = await _categoryService.AddAsync(category);
            var response = _mapper.Map<CategoryDto>(result);
            return response is not null
                ? CreateActionResult(Response<CategoryDto>.Success(response, 200))
                : CreateActionResult(Response<NoContent>.Fail("Not created", 400));
        }
    }
}
