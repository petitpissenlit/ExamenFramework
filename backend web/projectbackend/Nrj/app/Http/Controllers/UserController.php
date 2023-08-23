<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\User;
use Illuminate\Validation\Rule;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Facades\Validator;
use Illuminate\Support\Facades\Session;
use Illuminate\Support\Facades\Storage;
use Illuminate\Support\Facades\DB;
class UserController extends Controller
{
    public function profile($name)
    {
        $user = User::where('name', $name)->firstOrFail();
        
        return view('users.profile', compact('user'));
    }

   public function store(Request $request)
{
    $request->validate([
        'name' => 'required|string|max:255',
        'email' => 'required|email|unique:users',
        'password' => 'required|string|min:6|confirmed',
        'birthday' => 'required|date',
        'avatar' => 'nullable|image|mimes:jpeg,png,jpg,gif|max:2048',
        'bio' => 'nullable|string|max:255',
    ]);

    $avatarPath = null;
    if ($request->hasFile('avatar')) {
        $avatar = $request->file('avatar');
        $avatarName = time() . '_' . $avatar->getClientOriginalName();
        $avatar->move(public_path('avatars'), $avatarName);
        $avatarPath = 'avatars/' . $avatarName;
    }

    $user = new User([
        'name' => $request->input('name'),
        'email' => $request->input('email'),
        'password' => Hash::make($request->input('password')),
        'birthday' => $request->input('birthday'),
        'avatar' => $avatarPath,
        'bio' => $request->input('bio'),
    ]);
    $user->save();


}



public function update(Request $request, $name)
{
    $user = User::where('name', $name)->firstOrFail();

    

    $user->name = $request->input('name');
    $user->password = Hash::make($request->input('password'));
    $user->email = $request->input('email');
    
    $user->bio = $request->input('bio');

    if ($request->hasFile('avatar')) {
        $avatar = $request->file('avatar');
        $avatarPath = $avatar->store('avatars', 'public');
        $user->avatar = $avatarPath;
    }

    $user->save();

    Session::flash('success', 'Profiel succesvol bijgewerkt');

    return redirect()->route('profile', ['name' => $user->name]);
}

}

