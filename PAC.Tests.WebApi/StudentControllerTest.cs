namespace PAC.Tests.WebApi;
using System.Collections.ObjectModel;
using System.Data;
using Moq;
using PAC.IBusinessLogic;
using PAC.Domain;
using PAC.WebAPI;
using Microsoft.AspNetCore.Mvc;

[TestClass]
public class StudentControllerTest
{
    private Mock<IStudentLogic> mock;
    private StudentController api;
    private Student student;
    // MedicamentoComprado medicamentoComprado;
    //private IEnumerable<Compra> compras;

    [TestInitialize]
    public void InitTest()
    {
        mock = new Mock<IStudentLogic>(MockBehavior.Strict);
        api = new StudentController(mock.Object);
        student = new Student()
        {
            Id = 1,
            Name = "Danilo"            
        };
    }

    [TestInitialize]
    public void PostStudentOk()
    {
        mock.Setup(x => x.InsertStudents(It.IsAny<Student>()));
        var resultado = api.InsertStudent(student);

        var objeto = resultado as ObjectResult;
        var statusCode = objeto.StatusCode;

        mock.VerifyAll();
        Assert.AreEqual(201, statusCode);
    }

    [TestInitialize]
    public void PostStudentFail()
    {
        mock.Setup(x => x.InsertStudents(It.IsAny<Student>()));
        var resultado = api.InsertStudent(student);

        var objeto = resultado as ObjectResult;
        var statusCode = objeto.StatusCode;

        mock.VerifyAll();
        Assert.AreEqual(400, statusCode);
    }
}
