using AutoFixture;
using LightsOut.Services.Data.TableEntity;
using Moq;
using Solvtio.Services.Implementations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Solvtio.Data;

namespace Solvtio.Services.Tests
{
    public class LightsOutServiceTests
    {
        private readonly ConfiguracionService _service;
        private readonly Mock<IConfiguracionRepository> _repositoryMock;
        private readonly Fixture _fixture;
        private readonly List<Configuracion> _settings;

        public LightsOutServiceTests()
        {
            _repositoryMock = new Mock<IConfiguracionRepository>();
            _service = new ConfiguracionService(_repositoryMock.Object);
            _fixture = new Fixture();

            _settings = _fixture
                .Build<Configuracion>()
                .WithAutoProperties()
                .CreateMany(5)
                .ToList();
            _settings[0] = new Configuracion();
        }

        [Fact]
        public void GetAllLightsOutSetting_RetriveData()
        {
            _repositoryMock
                .Setup(x => x.GetAllConfiguracion())
                .Returns(_settings);

            var result = _service.GetAllConfiguracion();

            Assert.NotNull(result);
            Assert.True(result.Count() > 0);
            _repositoryMock.Verify(x => x.GetAllConfiguracion(), Times.Once);
        }

        [Fact]
        public async Task GetLightsOutSettingByNameAsync_Ok()
        {
            _repositoryMock
                .Setup(x => x.GetConfiguracionByNameAsync(It.IsAny<string>()))
                .ReturnsAsync(_settings.First());

            var result = await _service.GetConfiguracionByNameAsync("BoardSize");

            Assert.NotNull(result);
            //Assert.Equal("5", result.SettingValue);
            _repositoryMock.Verify(x => x.GetConfiguracionByNameAsync(It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public async Task GetLightsOutSettingByNameAsync_Ko_SettingNotExist()
        {
            _repositoryMock
                .Setup(x => x.GetConfiguracionByNameAsync(It.IsAny<string>()))
                .ReturnsAsync((Configuracion)null);

            var result = await _service.GetConfiguracionByNameAsync("SettingNotExist");

            Assert.Null(result);
            _repositoryMock.Verify(x => x.GetConfiguracionByNameAsync(It.IsAny<string>()), Times.Once);
        }

        //[Fact]
        //public async Task GetLightsOutModelAsync_Ok()
        //{
        //    _repositoryMock
        //        .Setup(x => x.GetConfiguracionByNameAsync(It.IsAny<string>()))
        //        .ReturnsAsync(_settings.First());

        //    var gameBoardModel = await _service.GetLightsOutModelAsync();

        //    Assert.NotNull(gameBoardModel);
        //    Assert.Equal(5, gameBoardModel.BoardSize);
        //    Assert.Equal(5, gameBoardModel.Rows.Count);
        //    Assert.Equal(5, gameBoardModel.Rows[0].Count);
        //    _repositoryMock.Verify(x => x.GetLightsOutSettingByNameAsync(It.IsAny<string>()), Times.Once);
        //}

        //[Fact]
        //public async Task GetLightsOutModelAsync_SomeLightsOn()
        //{
        //    _repositoryMock
        //        .Setup(x => x.GetLightsOutSettingByNameAsync(It.IsAny<string>()))
        //        .ReturnsAsync(_settings.First());

        //    var gameBoardModel = await _service.GetLightsOutModelAsync();

        //    Assert.NotNull(gameBoardModel);
        //    Assert.True(gameBoardModel.BoardSizeOn > 0);
        //    Assert.True(gameBoardModel.BoardSizeOn < gameBoardModel.BoardSize * gameBoardModel.BoardSize);
        //}
    }
}
