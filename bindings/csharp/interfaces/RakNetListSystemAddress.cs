/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SLNet {

using System;
using System.Runtime.InteropServices;

public class RakNetListSystemAddress : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RakNetListSystemAddress(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RakNetListSystemAddress obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RakNetListSystemAddress() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SLikeNetPINVOKE.delete_RakNetListSystemAddress(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

    public SystemAddress this[int index]  
    {  
        get   
        {
            return Get((uint)index); // use indexto retrieve and return another value.    
        }  
        set   
        {
            Replace(value, value, (uint)index, "Not used", 0);// use index and value to set the value somewhere.   
        }  
    } 

  public RakNetListSystemAddress() : this(SLikeNetPINVOKE.new_RakNetListSystemAddress__SWIG_0(), true) {
  }

  public RakNetListSystemAddress(RakNetListSystemAddress original_copy) : this(SLikeNetPINVOKE.new_RakNetListSystemAddress__SWIG_1(RakNetListSystemAddress.getCPtr(original_copy)), true) {
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public RakNetListSystemAddress CopyData(RakNetListSystemAddress original_copy) {
    RakNetListSystemAddress ret = new RakNetListSystemAddress(SLikeNetPINVOKE.RakNetListSystemAddress_CopyData(swigCPtr, RakNetListSystemAddress.getCPtr(original_copy)), false);
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SystemAddress Get(uint position) {
    SystemAddress ret = new SystemAddress(SLikeNetPINVOKE.RakNetListSystemAddress_Get(swigCPtr, position), false);
    return ret;
  }

  public void Push(SystemAddress input, string file, uint line) {
    SLikeNetPINVOKE.RakNetListSystemAddress_Push(swigCPtr, SystemAddress.getCPtr(input), file, line);
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public SystemAddress Pop() {
    SystemAddress ret = new SystemAddress(SLikeNetPINVOKE.RakNetListSystemAddress_Pop(swigCPtr), false);
    return ret;
  }

  public void Insert(SystemAddress input, uint position, string file, uint line) {
    SLikeNetPINVOKE.RakNetListSystemAddress_Insert__SWIG_0(swigCPtr, SystemAddress.getCPtr(input), position, file, line);
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(SystemAddress input, string file, uint line) {
    SLikeNetPINVOKE.RakNetListSystemAddress_Insert__SWIG_1(swigCPtr, SystemAddress.getCPtr(input), file, line);
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Replace(SystemAddress input, SystemAddress filler, uint position, string file, uint line) {
    SLikeNetPINVOKE.RakNetListSystemAddress_Replace__SWIG_0(swigCPtr, SystemAddress.getCPtr(input), SystemAddress.getCPtr(filler), position, file, line);
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Replace(SystemAddress input) {
    SLikeNetPINVOKE.RakNetListSystemAddress_Replace__SWIG_1(swigCPtr, SystemAddress.getCPtr(input));
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAtIndex(uint position) {
    SLikeNetPINVOKE.RakNetListSystemAddress_RemoveAtIndex(swigCPtr, position);
  }

  public void RemoveAtIndexFast(uint position) {
    SLikeNetPINVOKE.RakNetListSystemAddress_RemoveAtIndexFast(swigCPtr, position);
  }

  public void RemoveFromEnd(uint num) {
    SLikeNetPINVOKE.RakNetListSystemAddress_RemoveFromEnd__SWIG_0(swigCPtr, num);
  }

  public void RemoveFromEnd() {
    SLikeNetPINVOKE.RakNetListSystemAddress_RemoveFromEnd__SWIG_1(swigCPtr);
  }

  public uint GetIndexOf(SystemAddress input) {
    uint ret = SLikeNetPINVOKE.RakNetListSystemAddress_GetIndexOf(swigCPtr, SystemAddress.getCPtr(input));
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint Size() {
    uint ret = SLikeNetPINVOKE.RakNetListSystemAddress_Size(swigCPtr);
    return ret;
  }

  public void Clear(bool doNotDeallocateSmallBlocks, string file, uint line) {
    SLikeNetPINVOKE.RakNetListSystemAddress_Clear(swigCPtr, doNotDeallocateSmallBlocks, file, line);
  }

  public void Preallocate(uint countNeeded, string file, uint line) {
    SLikeNetPINVOKE.RakNetListSystemAddress_Preallocate(swigCPtr, countNeeded, file, line);
  }

  public void Compress(string file, uint line) {
    SLikeNetPINVOKE.RakNetListSystemAddress_Compress(swigCPtr, file, line);
  }

}

}
