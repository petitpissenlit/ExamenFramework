@if(Session::has('success'))
    <div class="alert alert-success">
        {{ Session::get('success') }}
    </div>
@endif

@extends('layouts.app')

@section('content')
<div class="container">
    <div class="row justify-content-center">
        <div class="col-md-8">
            <div class="card">
                <div class="card-header">Profiel van {{$user->name }}</div>

                <div class="card-body">
                    <div class="row">
                        <div class="col-md-4">
                            <div class="text-center">
<img src="{{ asset('storage/' . $user->avatar) }}" alt="Avatar" width="50">
                            </div>
                        </div>
                        <div class="col-md-8">
                            <h4>Gebruikersnaam:</h4>
                            <p>{{ $user->name }}</p>

                            <h4>Geboortedatum:</h4>
                            <p>{{ $user->birthday }}</p>

                            <h4>About me:</h4>
                            <p>{{ $user->bio }}</p>
                        </div>
                    </div>

                    <hr>

                    <h2>Gemaakte Posts</h2>

                    @foreach ($user->posts as $post)
                        <a href="{{ route('posts.show', $post->id) }}">{{ $post->title }}</a><br>
                    @endforeach

                    <hr>

                    <h2>Gelikete Posts</h2>
                    @foreach ($user->likes as $like)
                        <a href="{{ route('posts.show', $like->post_id) }}">{{ $like->post->title }}</a><br>
                    @endforeach

                    <div class="card-footer">
                        <button class="btn btn-primary" type="button" data-bs-toggle="collapse"
                            data-bs-target="#profileOptions" aria-expanded="false" aria-controls="profileOptions">
                            Edit profile
                        </button>

                        <div class="collapse mt-3" id="profileOptions">
                            <form action="{{ route('profile.update', ['name' => $user->name]) }}" method="POST" enctype="multipart/form-data">
                                @csrf
                                @method('PUT')

                                <div class="mb-3">
                                    <label for="name" class="form-label">Gebruikersnaam</label>
                                    <input type="text" class="form-control" id="name" name="name"
                                        value="{{ $user->name }}" required>
                                </div>

                                <div class="mb-3">
                                    <label for="email" class="form-label">E-mail</label>
                                    <input type="email" class="form-control" id="email" name="email"
                                        value="{{ $user->email }}" required>
                                </div>

                                <div class="mb-3">
                                    <label for="password" class="form-label">Nieuw wachtwoord</label>
                                    <input type="password" class="form-control" id="password" name="password"
                                        placeholder="Nieuw wachtwoord">
                                </div>

                                <div class="mb-3">
                                    <label for="bio" class="form-label">Over mij</label>
                                    <textarea class="form-control" id="bio" name="bio"
                                        required>{{ $user->bio }}</textarea>
                                </div>

                                <div class="mb-3">
                                    <label for="avatar" class="form-label">Avatar</label>
                                    <input type="file" class="form-control" id="avatar" name="avatar">
                                </div>

                                <button type="submit" class="btn btn-primary">Opslaan</button>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

    </div>
</div>
@endsection
