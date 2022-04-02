using AutoFixture;
using LightsOut.Services.Data;
using LightsOut.Services.Data.TableEntity;
using LightsOut.Services.Implementations;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LightsOut.Services.Tests
{
    public class LightsOutServiceTests
    {
        private readonly LightsOutService _service;
        private readonly Mock<ILightsOutSettingRepository> _repositoryMock;
        private readonly Fixture _fixture;
        private readonly List<LightsOutSetting> _settings;

        public LightsOutServiceTests()
        {
            _repositoryMock = new Mock<ILightsOutSettingRepository>();
            _service = new LightsOutService(_repositoryMock.Object);
            _fixture = new Fixture();

            _settings = _fixture
                .Build<LightsOutSetting>()
                .WithAutoProperties()
                .CreateMany(5)
                .ToList();
            _settings[0] = new LightsOutSetting("BoardSize", "5");
        }

        [Fact]
        public void GetAllLightsOutSetting_RetriveData()
        {
            _repositoryMock
                .Setup(x => x.GetAllLightsOutSetting())
                .Returns(_settings);

            var result = _service.GetAllLightsOutSetting();

            Assert.NotNull(result);
            Assert.True(result.Count() > 0);
            _repositoryMock.Verify(x => x.GetAllLightsOutSetting(), Times.Once);
        }

        [Fact]
        public async Task GetLightsOutSettingByNameAsync_Ok()
        {
            _repositoryMock
                .Setup(x => x.GetLightsOutSettingByNameAsync(It.IsAny<string>()))
                .ReturnsAsync(_settings.First());

            var result = await _service.GetLightsOutSettingByNameAsync("BoardSize");

            Assert.NotNull(result);
            Assert.Equal("5", result.SettingValue);
            _repositoryMock.Verify(x => x.GetLightsOutSettingByNameAsync(It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public async Task GetLightsOutSettingByNameAsync_Ko_SettingNotExist()
        {
            _repositoryMock
                .Setup(x => x.GetLightsOutSettingByNameAsync(It.IsAny<string>()))
                .ReturnsAsync((LightsOutSetting)null);

            var result = await _service.GetLightsOutSettingByNameAsync("SettingNotExist");

            Assert.Null(result);
            _repositoryMock.Verify(x => x.GetLightsOutSettingByNameAsync(It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public async Task GetLightsOutModelAsync_Ok()
        {
            _repositoryMock
                .Setup(x => x.GetLightsOutSettingByNameAsync(It.IsAny<string>()))
                .ReturnsAsync(_settings.First());

            var gameBoardModel = await _service.GetLightsOutModelAsync();

            Assert.NotNull(gameBoardModel);
            Assert.Equal(5, gameBoardModel.BoardSize);
            Assert.Equal(5, gameBoardModel.Rows.Count);
            Assert.Equal(5, gameBoardModel.Rows[0].Count);
            _repositoryMock.Verify(x => x.GetLightsOutSettingByNameAsync(It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public async Task GetLightsOutModelAsync_SomeLightsOn()
        {
            _repositoryMock
                .Setup(x => x.GetLightsOutSettingByNameAsync(It.IsAny<string>()))
                .ReturnsAsync(_settings.First());

            var gameBoardModel = await _service.GetLightsOutModelAsync();

            Assert.NotNull(gameBoardModel);
            Assert.True(gameBoardModel.BoardSizeOn > 0);
            Assert.True(gameBoardModel.BoardSizeOn < gameBoardModel.BoardSize * gameBoardModel.BoardSize);
        }
    }
}
