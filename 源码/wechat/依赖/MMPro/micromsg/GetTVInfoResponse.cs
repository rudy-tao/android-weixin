﻿namespace micromsg
{
    using ProtoBuf;
    using System;
    using System.ComponentModel;

    [Serializable, ProtoContract(Name="GetTVInfoResponse")]
    public class GetTVInfoResponse : IExtensible
    {
        private micromsg.BaseResponse _BaseResponse;
        private string _DescriptionXML = "";
        private string _TVID = "";
        private uint _Type;
        private IExtension extensionObject;

        IExtension IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }

        [ProtoMember(1, IsRequired=true, Name="BaseResponse", DataFormat=DataFormat.Default)]
        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return this._BaseResponse;
            }
            set
            {
                this._BaseResponse = value;
            }
        }

        [ProtoMember(3, IsRequired=false, Name="DescriptionXML", DataFormat=DataFormat.Default), DefaultValue("")]
        public string DescriptionXML
        {
            get
            {
                return this._DescriptionXML;
            }
            set
            {
                this._DescriptionXML = value;
            }
        }

        [ProtoMember(4, IsRequired=false, Name="TVID", DataFormat=DataFormat.Default), DefaultValue("")]
        public string TVID
        {
            get
            {
                return this._TVID;
            }
            set
            {
                this._TVID = value;
            }
        }

        [ProtoMember(2, IsRequired=true, Name="Type", DataFormat=DataFormat.TwosComplement)]
        public uint Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this._Type = value;
            }
        }
    }
}

