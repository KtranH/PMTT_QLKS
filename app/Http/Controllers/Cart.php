<?php

namespace App\Http\Controllers;

use App\Models\KhachHang;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use RealRashid\SweetAlert\Facades\Alert;

class Cart extends Controller
{
    //
    public function Cart()
    {   
        $user = KhachHang::find(Auth::user()->ID);
        $selectCart = $user->gioHang()->get();
        return view('CartController.Cart', compact('selectCart'));
    }
    public function AddCart(Request $request)
    {
        $user = KhachHang::find(Auth::user()->ID);
        if($user->gioHang()->wherePivot('LOAIPHONG_ID', $request->roomID)->exists()) {
            $currentItem = $user->gioHang()
                ->wherePivot('LOAIPHONG_ID', $request->roomID)
                ->first();
            
            $user->gioHang()->updateExistingPivot($request->roomID, [
                'SOLUONG' => $currentItem->pivot->SOLUONG + 1, 'DONGIA' => $currentItem->GIATHUE * ($currentItem->pivot->SOLUONG + 1)
            ]);
        }
        else
        {
            $user->gioHang()->attach($request->roomID);
            $user->gioHang()->updateExistingPivot($request->roomID, [
                'DONGIA' => $user->gioHang()->wherePivot('LOAIPHONG_ID', $request->roomID)->first()->GIATHUE
            ]);
        }
        $countCart = $user->gioHang()->count();
        $quantity = $user->gioHang()->wherePivot('LOAIPHONG_ID', $request->roomID)->first()->pivot->SOLUONG;
        $sumCart = $user->gioHang()->get()->sum(function ($item) {
            return $item->pivot->DONGIA;
        });
        return response()->json(['success' => true, 'countCart' => $countCart, 'quantity' => $quantity, 'sumCart' => $sumCart]);
    }
    public function DeleteCart(Request $request)
    {
        $user = KhachHang::find(Auth::user()->ID);
        if($user->gioHang()->wherePivot('LOAIPHONG_ID', $request->roomID)->wherePivot('SOLUONG', '>', 1)->exists()) {
            $currentItem = $user->gioHang()
                ->wherePivot('LOAIPHONG_ID', $request->roomID)
                ->first();
            
            $user->gioHang()->updateExistingPivot($request->roomID, [
                'SOLUONG' => $currentItem->pivot->SOLUONG - 1, 'DONGIA' => $currentItem->GIATHUE * ($currentItem->pivot->SOLUONG - 1)
            ]);
            $flag = 0;
        }
        else
        {
            $user->gioHang()->detach($request->roomID);
            $flag = 1;
        }
        $countCart = $user->gioHang()->count();
        $sumCart = $user->gioHang()->get()->sum(function ($item) {
            return $item->pivot->DONGIA;
        });
        if($flag == 1)
        {
            $quantity = null;
            return response()->json(['success' => true, 'countCart' => $countCart , 'sumCart' => $sumCart, 'quantity' => $quantity, 'delete' => true]);
        }
        else
        {
            $quantity = $user->gioHang()->wherePivot('LOAIPHONG_ID', $request->roomID)->first()->pivot->SOLUONG;
            return response()->json(['success' => true, 'countCart' => $countCart , 'sumCart' => $sumCart, 'quantity' => $quantity, 'delete' => false]);
        }
    }
    public function DeleteAllCart()
    {
        $user = KhachHang::find(Auth::user()->ID);
        $user->gioHang()->detach();
        $countCart = $user->gioHang()->count();
        return response()->json(['success' => true, 'countCart' => $countCart]);
    }
}
