using Ap1_P1_LiamellCruz.DAL;
using Ap1_P1_LiamellCruz.Models;

namespace Ap1_P1_LiamellCruz.Services;

public class ArticuloService
{

    private readonly Contexto _contexto;
    private readonly int articulos;

    public ArticuloService(Contexto contexto)
    {
        _contexto = contexto;

    }

    public async Task<bool> Existe(int articuloId)
    {
    return await _contexto.Articulos
   .Where.(a => a.ArticuloId == articuloId);

    }

    public async Task<bool> Insertar(Articulos articulos)
    {
        _contexto.Articulos.Add(articulos);
           return await _contexto.SaveChangesAsync() > 0;

    }

    public async Task<bool> Modificar(Articulos articulos)
    {
        _contexto.Update(articulos);
        return await _contexto.SaveChangesAsync() > 0;

    }

    public async Task<bool> Guardar(Articulos articulos)
    {
        if (!await Existe(articulos.ArticulosId))
        return await Insertar(articulos);

        else
        return await Modificar(articulos);
    }

    public async Task<bool> Eliminar(int id)
    {
        var tecnicos = await _contexto.Articulos
           .Where(A => A.Articulos == id);
        return articulos > 0;
    }


}
