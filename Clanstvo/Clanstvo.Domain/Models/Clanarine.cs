﻿using BaseLibrary;
using Clanstvo.Commons;
using System.Data;

namespace Clanstvo.Domain.Models;
public class Clanarine : AggregateRoot<int>
{
    private bool _placenost;
    private float _iznos;
    private int _godina;
    private int _clanId;
    private DateTime _datum;



    public bool Placenost { get => _placenost; set => _placenost = value; }
    public float Iznos { get => _iznos; set => _iznos = value; }
    public int ClanId { get => _clanId; set => _clanId = value; }
    public DateTime Datum { get => _datum; set => _datum = value; }

    public Clanarine(int id, bool placenost, float iznos, int godina, int clanId ,DateTime datum) : base(id)
    {

        if (datum == DateTime.MinValue)
        {
            throw new ArgumentException($"'{nameof(datum)}' cannot be null or empty.", nameof(datum));
        }

        _placenost = placenost;
        _iznos = iznos;
        _godina = godina;
        _datum = datum;
        _clanId = clanId;
    }

    public override bool Equals(object? obj)
    {
        return obj is not null &&
                obj is Clanarine clanarina &&
                _id == clanarina._id &&
                _placenost == clanarina._placenost &&
                _iznos == clanarina._iznos &&
                _godina == clanarina._godina &&
                _datum == clanarina._datum &&
                _clanId == clanarina._clanId;
              
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_id, _placenost, _iznos, _godina, _clanId ,_datum);
    }

    public override Result IsValid()
        => Validation.Validate(
            (() => datum == DateTime.MinValue, "DatumRodenja can't be default value")
            );
}