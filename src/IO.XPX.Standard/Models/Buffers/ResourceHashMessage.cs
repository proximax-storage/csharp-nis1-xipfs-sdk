using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using FlatBuffers;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO.XPX.Standard.Models.Buffers
{
    public sealed class ResourceHashMessage
    {
        Table tbl = new Table();

        public static ResourceHashMessage getRootAsResourceHashMessage(ByteBuffer _bb)
        {
            return getRootAsResourceHashMessage(_bb, new ResourceHashMessage());
        }

        public static ResourceHashMessage getRootAsResourceHashMessage(ByteBuffer _bb, ResourceHashMessage obj)
        {
            return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
        }

        public void __init(int _i, ByteBuffer _bb)
        {
            tbl.bb_pos = _i;
            tbl.bb = _bb;
        }

        public ResourceHashMessage __assign(int _i, ByteBuffer _bb)
        {
            __init(_i, _bb);

            return this;
        }

        public string digest()
        {
            int o = tbl.__offset(4);

            return o != 0 ? tbl.__string(o + tbl.bb_pos) : null;
        }

        public ByteBuffer digestAsByteBuffer()
        {
            return new ByteBuffer(tbl.bb.ToArray(4, 1));
        }

        public string hash()
        {
            int o = tbl.__offset(6);

            return o != 0 ? tbl.__string(o + tbl.bb_pos) : null;
        }

        public ByteBuffer hashAsByteBuffer()
        {
            return new ByteBuffer(tbl.bb.ToArray(6, 1));
        }

        public string keywords()
        {
            int o = tbl.__offset(8);

            return o != 0 ? tbl.__string(o + tbl.bb_pos) : null;
        }

        public ByteBuffer keywordsAsByteBuffer()
        {
            return new ByteBuffer(tbl.bb.ToArray(8, 1));
        }

        public string metaData()
        {
            int o = tbl.__offset(10);

            return o != 0 ? tbl.__string(o + tbl.bb_pos) : null;
        }

        public ByteBuffer metaDataAsByteBuffer()
        {
            return new ByteBuffer(tbl.bb.ToArray(10, 1));
        }

        public string name()
        {
            int o = tbl.__offset(12);

            return o != 0 ? tbl.__string(o + tbl.bb_pos) : null;
        }

        public ByteBuffer nameAsByteBuffer()
        {
            return new ByteBuffer(tbl.bb.ToArray(12, 1));
        }

        public int size()
        {
            int o = tbl.__offset(14);

            return o != 0 ? tbl.bb.GetInt(o + tbl.bb_pos) : 0;
        }

        public long timestamp()
        {
            int o = tbl.__offset(16);

            return o != 0 ? tbl.bb.GetLong(o + tbl.bb_pos) : 0L;
        }

        public string type()
        {
            int o = tbl.__offset(18);

            return o != 0 ? tbl.__string(o + tbl.bb_pos) : null;
        }

        public ByteBuffer typeAsByteBuffer()
        {
            return new ByteBuffer(tbl.bb.ToArray(18, 1));
        }


        /// <summary>
        /// Create the resource hash Message
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="digestOffset"></param>
        /// <param name="hashOffset"></param>
        /// <param name="keywordOffset"></param>
        /// <param name="metaDataOffset"></param>
        /// <param name="nameOffset"></param>
        /// <param name="size"></param>
        /// <param name="timestamp"></param>
        /// <param name="typeOffset"></param>
        /// <returns>int</returns>
        public static int createResourceHashMessage(FlatBufferBuilder builder,
        int digestOffset,
        int hashOffset,
        int keywordsOffset,
        int metaDataOffset,
        int nameOffset,
        int size,
        long timestamp,
        int typeOffset)
            {
                builder.StartObject(8);
                addTimestamp(builder, timestamp);
                addType(builder, typeOffset);
                addSize(builder, size);
                addName(builder, nameOffset);
                addMetaData(builder, metaDataOffset);
                addKeywords(builder, keywordsOffset);
                addHash(builder, hashOffset);
                addDigest(builder, digestOffset);
                return endResourceHashMessage(builder);
            }

        public static void startResourceHashMessage(FlatBufferBuilder builder)
        {
            builder.StartObject(8);
        }

        /// <summary>
        /// Adds the digest
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="digestOffset"></param>
        public static void addDigest(FlatBufferBuilder builder, int digestOffset)
        {
            builder.AddOffset(0, digestOffset, 0);
        }

        /// <summary>
        /// Adds the hash
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="hashOffset"></param>
        public static void addHash(FlatBufferBuilder builder, int hashOffset)
        {
            builder.AddOffset(1, hashOffset, 0);
        }

        /// <summary>
        /// Adds the keywords
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="keywordsOffset"></param>
        public static void addKeywords(FlatBufferBuilder builder, int keywordsOffset)
        {
            builder.AddOffset(2, keywordsOffset, 0);
        }

        /// <summary>
        /// Adds the meta data
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="metaDataOffset"></param>
        public static void addMetaData(FlatBufferBuilder builder, int metaDataOffset)
        {
            builder.AddOffset(3, metaDataOffset, 0);
        }

        /// <summary>
        /// Adds the name
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="nameOffset"></param>
        public static void addName(FlatBufferBuilder builder, int nameOffset)
        {
            builder.AddOffset(4, nameOffset, 0);
        }

        /// <summary>
        /// Adds the size
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="size"></param>
        public static void addSize(FlatBufferBuilder builder, int size)
        {
            builder.AddInt(5, size, 0);
        }

        /// <summary>
        /// Adds the timestamp
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="timestamp"></param>
        public static void addTimestamp(FlatBufferBuilder builder, long timestamp)
        {
            builder.AddLong(6, timestamp, 0L);
        }

        /// <summary>
        /// Adds the type
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="typeOffset"></param>
        public static void addType(FlatBufferBuilder builder, int typeOffset)
        {
            builder.AddOffset(7, typeOffset, 0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static int endResourceHashMessage(FlatBufferBuilder builder)
        {
            int o = builder.EndObject();

            return o;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="offset"></param>
        public static void finishResourceHashMessageBuffer(FlatBufferBuilder builder, int offset)
        {
            builder.Finish(offset);
        }


        /// <summary>
        /// Converts byte to object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>ByteBuffer</returns>
        public static ByteBuffer convertToByteBufferObj(byte[] obj)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(obj, 0, obj.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            ByteBuffer bbobj = (ByteBuffer)binForm.Deserialize(memStream);

            return bbobj;
        }
    }
}
